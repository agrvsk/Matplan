using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Matplan.EntityContracts.Repositories.Shared;
using Matplan.Services.Contracts;
using Matplan.Shared.Enums;
using Matplan.Shared.KodtabellDtos;
using Matplan.Shared.Paginering;
using Matplan.Shared.Requests;

namespace Matplan.Services;
//===================================================
//KodtabellDto
//===================================================
//Z_Veckodag	    byte:Storedpfu  string?:Displayed
//Z_Steg            byte:Storedpfu  string?:Displayed
//Z_Plandag         byte:Storedpfu  string?:Displayed
//Z_NejJa           byte:Storedpfu  string?:Displayed
//Z_Matratt         byte:Storedpfu  string?:Displayed
//Z_Maltid          byte:Storedpfu  string?:Displayed
//Z_Ja              byte:Storedpfu  string?:Displayed
//Z_Handlar         byte:Storedpfu  string?:Displayed
//Z_BristViaSMS     byte:Storedpfu  string?:Displayed
//Z_BeredInkop      byte:Storedpfu  string?:Displayed
//Z_ART_RecEnh      byte:Storedpfu  string?:Displayed

//===================================================
//KodtabellDto???
//===================================================
//Z_VG              string:Storedpfu string?:DisplayedVG
//Z_Kat             string:Storedpfu string?:Displayed
//Z_HI              string:Storedpfu string?:Displayed
//Z_ART_Typ         string:Storedpfu string?:Displayed
//Z_ART_Lagring     string:Storedpfu string?:Displayed
//Z_ART_Grupp       string:Storedpfu string?:Displayed

//===================================================
//KodtabellDto???
//===================================================
//Z_Datum           DateTime:Datum      string?:Dag

//===================================================
//KodtabellDto???
//===================================================
//Z_ART_Enhet       string:Storedpfu
//Z_AltBild         string:Storedpfu

public class KodtabellService : IKodtabellService
{
    private readonly IUnitOfWork _uow;
    private readonly IMapper _mapper;

    private readonly Dictionary<ByteKodtabeller, Func<KodtabellByteRequestParams, bool, Task<object>>> _bytehandlers;
    private readonly Dictionary<StringKodtabeller, Func<KodtabellStringRequestParams, bool, Task<object>>> _stringhandlers;

    public KodtabellService(IUnitOfWork uow, IMapper mapper)
    {
        this._uow = uow;
        this._mapper = mapper;

        // Registrerar alla Coded Value Lists som har ett bytevärde som nyckel.
        _bytehandlers = new()
        {
            { ByteKodtabeller.Z_Veckodag, async (p, t) => await _uow.Z_VeckodagRepository.GetZ_VeckodagListAsync(p, t) },
            { ByteKodtabeller.Z_Steg, async (p, t) => await _uow.Z_StegRepository.GetZ_StegListAsync(p, t) },
            { ByteKodtabeller.Z_Plandag, async (p, t) => await _uow.Z_PlandagRepository.GetZ_PlandagListAsync(p, t) },
            { ByteKodtabeller.Z_NejJa, async (p, t) => await _uow.Z_NejJaRepository.GetZ_NejJaListAsync(p, t) },
            { ByteKodtabeller.Z_Matratt, async (p, t) => await _uow.Z_MatrattRepository.GetZ_MatrattListAsync(p, t) },
            { ByteKodtabeller.Z_Maltid, async (p, t) => await _uow.Z_MaltidRepository.GetZ_MaltidListAsync(p, t) },
            { ByteKodtabeller.Z_Ja, async (p, t) => await _uow.Z_JaRepository.GetZ_JaListAsync(p, t) },
            { ByteKodtabeller.Z_Handlar, async (p, t) => await _uow.Z_HandlarRepository.GetZ_HandlarListAsync(p, t) },
            { ByteKodtabeller.Z_BristViaSMS, async (p, t) => await _uow.Z_BristViaSMSRepository.GetZ_BristViaSMSListAsync(p, t) },
            { ByteKodtabeller.Z_BeredInkop, async (p, t) => await _uow.Z_BeredInkopRepository.GetZ_BeredInkopListAsync(p, t) },
            { ByteKodtabeller.Z_ART_RecEnh, async (p, t) => await _uow.Z_ART_RecEnhRepository.GetZ_ART_RecEnhListAsync(p, t) }
        };

        //Registrerar alla Coded Value Lists som har en string som nyckel.
        _stringhandlers = new()
        {
            { StringKodtabeller.Z_Kat, async (p, t) => await _uow.Z_KatRepository.GetZ_KatListAsync(p, t) },
            { StringKodtabeller.Z_ART_Grupp, async (p, t) => await _uow.Z_ART_GruppRepository.GetZ_ART_GruppListAsync(p, t) },
            { StringKodtabeller.Z_ART_Enhet, async (p, t) => await _uow.Z_ART_EnhetRepository.GetZ_ART_EnhetListAsync(p, t) },
            { StringKodtabeller.Z_ART_Lagring, async (p, t) => await _uow.Z_ART_LagringRepository.GetZ_ART_LagringListAsync(p, t) },
            { StringKodtabeller.Z_AltBild, async (p, t) => await _uow.Z_AltBildRepository.GetZ_AltBildListAsync(p, t) },
            { StringKodtabeller.Z_ART_Typ, async (p, t) => await _uow.Z_ART_TypRepository.GetZ_ART_TypListAsync(p, t) },
            { StringKodtabeller.Z_HI, async (p, t) => await _uow.Z_HIRepository.GetZ_HIListAsync(p, t) },
            { StringKodtabeller.Z_VG, async (p, t) => await _uow.Z_VGRepository.GetZ_VGListAsync(p, t) }
        };


    }



    public async Task<(IEnumerable<KodtabellStringDto>? items, MetaData? metaData)> GetStringKodtabellAsync(KodtabellStringRequestParams requestParams, bool trackChanges = false)
    {
        var handler = _stringhandlers[requestParams.StringKodtabell];
        var result = await handler(requestParams, trackChanges);
        dynamic pagedList = result;
        var items = _mapper.Map<IEnumerable<KodtabellStringDto>>(pagedList.Items);
        var meta = pagedList.MetaData;
        return (items, meta);

    }
    public async Task<(IEnumerable<KodtabellByteDto>? items, MetaData? metaData)> GetByteKodtabellAsync(KodtabellByteRequestParams requestParams, bool trackChanges = false)
    {
        var handler = _bytehandlers[requestParams.ByteKodtabell];
        var result = await handler(requestParams, trackChanges);
        dynamic pagedList = result;
        var items = _mapper.Map<IEnumerable<KodtabellByteDto>>(pagedList.Items);
        var meta = pagedList.MetaData;
        return (items, meta);
    }


    //    public async Task<CourseDto> CreateCourseAsync(CourseCreateDto courseDto)
    //    {
    //        //var course= mapper.Map<Course>(courseDto);
    //        //uow.CourseRepository.Create(course);
    //        //var newCourseDto = mapper.Map<CourseDto>(course);
    //        //await uow.CompleteAsync();

    //        //return newCourseDto;
    //    }
    //    public async Task<CourseDto> UpdateCourseAsync(CourseUpdateDto courseUpdDto)
    //    {
    //        //var course = mapper.Map<Course>(courseUpdDto);
    //        //uow.CourseRepository.Update(course);
    //        //await uow.CompleteAsync();
    //        //return mapper.Map<CourseDto>(course);
    ////        return true;
    //    }
    //    public async Task<bool> DeleteCourseAsync(Guid courseId)
    //    {
    //        //var course = await uow.CourseRepository.GetCourseByIdAsync(courseId);
    //        //if (course == null)
    //        //    return false;

    //        //var documents = await uow.DocumentRepository.GetDocumentsByParentAsync(courseId, "course");
    //        //foreach (var doc in documents)
    //        //{
    //        //    uow.DocumentRepository.Delete(doc);
    //        //}

    //        //var comrades = await uow.User_USRRepository.GetUsersByCourseIdAsync(course.Id);

    //        //foreach (var ussr in comrades)
    //        //{            
    //        //    uow.User_USRRepository.Delete(ussr);
    //        //}

    //        //var modules = await uow.ModuleRepository.GetModulesByCourseIdAsync(courseId);


    //        //foreach (var mod in modules)
    //        //{
    //        //    var activities = await uow.ModuleActivityRepository.GetModuleActivitiesByModuleIdAsync(mod.Id);

    //        //    foreach (var act in activities)
    //        //    {
    //        //        uow.ModuleActivityRepository.Delete(act);
    //        //    }

    //        //    uow.ModuleRepository.Delete(mod);
    //        //}


    //        //uow.CourseRepository.Delete(course);
    //        //await uow.SaveAsync();
    //        //return true;
    //    }


}
