using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Matplan.EntityContracts.Repositories.Shared;
using Matplan.Services.Contracts;
using Matplan.Shared.EntityDtos;
using Matplan.Shared.KodtabellDtos;
using Matplan.Shared.Paginering;
using Matplan.Shared.Requests;

namespace Matplan.Services;

public class ArtikelService : IArtikelService
{
    private readonly IUnitOfWork _uow;
    private readonly IMapper _mapper;
    public ArtikelService(IUnitOfWork uow, IMapper mapper)
    {
        this._uow = uow;
        this._mapper = mapper;
    }

    public async Task<(IEnumerable<ArtikelDto>? items, MetaData? metaData)> GetArtikelListAsync(ArtikelRequestParams requestParams, bool trackChanges = false)
    {
        var pagedList = await _uow.Artikel_ARTRepository.GetArtikel_ARTListAsync(requestParams, trackChanges);
        var dto = _mapper.Map<IEnumerable<ArtikelDto>>(pagedList.Items);
        //foreach (var dto in DeviationDtos)
        //{
        //    dto.CreatedAt = dto.CreatedAt.ToSwedishTime();
        //}
        return (dto, pagedList.MetaData);

    }
}
