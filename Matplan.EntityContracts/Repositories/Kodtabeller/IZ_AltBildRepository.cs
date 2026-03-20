using System;
using System.Collections.Generic;
using System.Text;
using Matplan.EntityContracts.Repositories.Shared;
using Matplan.EntityModels.Models;
using Matplan.Shared.Requests;

namespace Matplan.EntityContracts.Repositories.Kodtabeller;

/*
Z_Veckodag      byte:Storedpfu		string?:Displayed
Z_Steg		    byte:Storedpfu 		string?:Displayed
Z_Plandag	    byte:Storedpfu 		string?:Displayed
Z_NejJa		    byte:Storedpfu 		string?:Displayed
Z_Matratt	    byte:Storedpfu 		string?:Displayed
Z_Maltid	    byte:Storedpfu 		string?:Displayed
Z_Ja		    byte:Storedpfu 		string?:Displayed
Z_Handlar	    byte:Storedpfu 		string?:Displayed
Z_BristViaSMS	byte:Storedpfu 		string?:Displayed
Z_BeredInkop	byte:Storedpfu 		string?:Displayed
Z_ART_RecEnh	byte:Storedpfu 		string?:Displayed

Z_VG		    string:Storedpfu	string?:DisplayedVG
Z_Kat		    string:Storedpfu 	string?:Displayed
Z_HI		    string:Storedpfu 	string?:Displayed
Z_ART_Typ	    string:Storedpfu 	string?:Displayed
Z_ART_Lagring	string:Storedpfu 	string?:Displayed
Z_ART_Grupp	    string:Storedpfu 	string?:Displayed

Z_Datum		    DateTime:Datum 		string?:Dag

Z_ART_Enhet	    string:Storedpfu 	
Z_AltBild	    string:Storedpfu 
*/

public interface IZ_AltBildRepository
{
    Task<Z_AltBild?> GetZ_AltBildAsync(string id, bool trackChanges = false);
    Task<IPagedList<Z_AltBild>> GetZ_AltBildListAsync(RequestParams requestParams, bool trackChanges = false);
    Task<bool> Z_AltBildExistAsync(string id);
    void Insert(Z_AltBild Deviation);
    void Update(Z_AltBild Deviation);
    void Delete(Z_AltBild deviation);

}
