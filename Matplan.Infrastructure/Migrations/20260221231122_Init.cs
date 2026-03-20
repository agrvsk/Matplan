using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Matplan.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artikel_ART",
                columns: table => new
                {
                    ART_ArtikelNr = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ART_USR_Rsn = table.Column<long>(type: "bigint", nullable: false),
                    ART_ART_ArtikelNr = table.Column<long>(type: "bigint", nullable: true),
                    ART_ArtikelNamn = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ART_LagerSaldo = table.Column<int>(type: "int", nullable: true),
                    ART_LagersaldoUt = table.Column<int>(type: "int", nullable: true),
                    ART_MinLager = table.Column<int>(type: "int", nullable: true),
                    ART_Ledtid = table.Column<int>(type: "int", nullable: true),
                    ART_Memo = table.Column<string>(type: "text", nullable: true),
                    ART_Typ = table.Column<int>(type: "int", nullable: true),
                    ART_Lagring = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    ART_BastForeDatum = table.Column<DateTime>(type: "datetime", nullable: true),
                    ART_Enhet = table.Column<string>(type: "char(9)", unicode: false, fixedLength: true, maxLength: 9, nullable: true),
                    ART_Pris = table.Column<int>(type: "int", nullable: true),
                    ART_PrisFrp = table.Column<int>(type: "int", nullable: true),
                    ART_Belopp = table.Column<int>(type: "int", nullable: true),
                    ART_AltBild = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ART_ImgTyp = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    ART_VideoJa = table.Column<byte>(type: "tinyint", nullable: true),
                    ART_UserNy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ART_DateNy = table.Column<DateTime>(type: "datetime", nullable: true),
                    ART_UserMod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ART_DateMod = table.Column<DateTime>(type: "datetime", nullable: true),
                    ART_HI = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ART_VG = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ART_Kat = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ART_Klassisk = table.Column<byte>(type: "tinyint", nullable: true),
                    ART_Fettsnalt = table.Column<byte>(type: "tinyint", nullable: true),
                    ART_GI = table.Column<byte>(type: "tinyint", nullable: true),
                    ART_GL = table.Column<byte>(type: "tinyint", nullable: true),
                    ART_Vego = table.Column<byte>(type: "tinyint", nullable: true),
                    ART_Husman = table.Column<byte>(type: "tinyint", nullable: true),
                    ART_Laktosfritt = table.Column<byte>(type: "tinyint", nullable: true),
                    ART_LCHF = table.Column<byte>(type: "tinyint", nullable: true),
                    ART_Glutenfritt = table.Column<byte>(type: "tinyint", nullable: true),
                    ART_GramPerDl = table.Column<int>(type: "int", nullable: true),
                    ART_GramPerSt = table.Column<int>(type: "int", nullable: true),
                    ART_GramPerTsk = table.Column<int>(type: "int", nullable: true),
                    ART_Forslag = table.Column<int>(type: "int", nullable: true),
                    ART_Sats = table.Column<int>(type: "int", nullable: true),
                    ART_LagerBelopp = table.Column<int>(type: "int", nullable: true),
                    ART_JustVeckodag = table.Column<byte>(type: "tinyint", nullable: true),
                    ART_BehovTot = table.Column<int>(type: "int", nullable: true),
                    ART_KlientNamn = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ART_URL_Link = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    ART_URL_Text = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    ART_URL = table.Column<string>(type: "varchar(2000)", unicode: false, maxLength: 2000, nullable: true),
                    ART_Publicera = table.Column<int>(type: "int", nullable: true),
                    ART_Aktuell = table.Column<byte>(type: "tinyint", nullable: true),
                    ART_ForslagIdag = table.Column<int>(type: "int", nullable: true),
                    ART_DaglForbr = table.Column<int>(type: "int", nullable: true),
                    ART_DateUppdat = table.Column<DateTime>(type: "datetime", nullable: true),
                    ART_Inkop = table.Column<int>(type: "int", nullable: true),
                    ART_OpOrdNrLast = table.Column<byte>(type: "tinyint", nullable: true),
                    ART_FlashAdd = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ART_PrisDatum = table.Column<DateTime>(type: "datetime", nullable: true),
                    ART_Losvikt = table.Column<int>(type: "int", nullable: true),
                    ART_Grupp = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    ART_IngariAnt = table.Column<int>(type: "int", nullable: true),
                    ART_AnsvUser = table.Column<long>(type: "bigint", nullable: true),
                    ART_ProduktArtikelNr = table.Column<long>(type: "bigint", nullable: true),
                    ART_ProduktArtikelNamn = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ART_AntalBlogposter = table.Column<int>(type: "int", nullable: true),
                    ART_InkopEnhet = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ART_LagerSaldoSt = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ART_AntDAP = table.Column<int>(type: "int", nullable: true),
                    ART_AntBOM = table.Column<int>(type: "int", nullable: true),
                    ART_FinnsAlltidHemma = table.Column<int>(type: "int", nullable: true),
                    ART_DAP_Kvantitet = table.Column<int>(type: "int", nullable: true),
                    ART_BeloppFinns = table.Column<int>(type: "int", nullable: true),
                    ART_RankProcFinns = table.Column<int>(type: "int", nullable: true),
                    ART_USK_KvantitetForslag = table.Column<int>(type: "int", nullable: true),
                    ART_AktDagar = table.Column<int>(type: "int", nullable: true),
                    ART_Rang = table.Column<int>(type: "int", nullable: true),
                    ART_Sok = table.Column<string>(type: "varchar(2500)", unicode: false, maxLength: 2500, nullable: true),
                    ART_Sok_Ravaror = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    ART_kCal = table.Column<int>(type: "int", nullable: true),
                    ART_kCalSum = table.Column<int>(type: "int", nullable: true),
                    ART_kCalFormula = table.Column<int>(type: "int", nullable: true),
                    ART_TillPlan = table.Column<byte>(type: "tinyint", nullable: true),
                    ART_AgentDatum = table.Column<DateTime>(type: "datetime", nullable: true),
                    ART_Upload = table.Column<string>(type: "text", nullable: true),
                    ART_Image = table.Column<byte[]>(type: "image", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Artikel_ART_PK", x => x.ART_ArtikelNr);
                });

            migrationBuilder.CreateTable(
                name: "Batch_BAT",
                columns: table => new
                {
                    BAT_Id = table.Column<long>(type: "bigint", nullable: false),
                    BAT_Namn = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    BAT_AntalLoopar = table.Column<long>(type: "bigint", nullable: true),
                    BAT_Sleeptime = table.Column<int>(type: "int", nullable: true),
                    BAT_SimDatum = table.Column<DateTime>(type: "datetime", nullable: true),
                    BAT_PayPal = table.Column<byte>(type: "tinyint", nullable: true),
                    BAT_DIBS = table.Column<byte>(type: "tinyint", nullable: true),
                    BAT_IPInfo = table.Column<byte>(type: "tinyint", nullable: true),
                    BAT_URL = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    BAT_SERVERPATH = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    BAT_RESIZE = table.Column<bool>(type: "bit", nullable: true),
                    BAT_MAXWIDTH = table.Column<short>(type: "smallint", nullable: true),
                    BAT_MAXHEIGHT = table.Column<short>(type: "smallint", nullable: true),
                    BAT_COMPRESS = table.Column<bool>(type: "bit", nullable: true),
                    BAT_QUALITY = table.Column<decimal>(type: "numeric(10,2)", nullable: true),
                    BAT_BASE64 = table.Column<bool>(type: "bit", nullable: true),
                    BAT_CHMOD = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Batch_BAT_PK", x => x.BAT_Id);
                });

            migrationBuilder.CreateTable(
                name: "Behov_BOM_BBM",
                columns: table => new
                {
                    BBM_User = table.Column<long>(type: "bigint", nullable: false),
                    BBM_ArtikelNr = table.Column<long>(type: "bigint", nullable: false),
                    BBM_Datum = table.Column<DateTime>(type: "datetime", nullable: false),
                    BBM_BOM_OpNr = table.Column<byte>(type: "tinyint", nullable: false),
                    BBM_BOM_OpOrdNr = table.Column<byte>(type: "tinyint", nullable: false),
                    BBM_Kvant = table.Column<int>(type: "int", nullable: true),
                    BBM_IngArtikelNr = table.Column<long>(type: "bigint", nullable: true),
                    BBM_BehovRepl = table.Column<int>(type: "int", nullable: true),
                    BBM_Faktor = table.Column<int>(type: "int", nullable: true),
                    BBM_BOMUt = table.Column<int>(type: "int", nullable: true),
                    BBM_IngDatum = table.Column<DateTime>(type: "datetime", nullable: true),
                    BBM_IngUser = table.Column<long>(type: "bigint", nullable: true),
                    BBM_Ledtid = table.Column<int>(type: "int", nullable: true),
                    BBM_JustVeckodag = table.Column<byte>(type: "tinyint", nullable: true),
                    BBM_RecKvant = table.Column<int>(type: "int", nullable: true),
                    BBM_RecEnh = table.Column<byte>(type: "tinyint", nullable: true),
                    BBM_Sats = table.Column<int>(type: "int", nullable: true),
                    BBM_BOMUtSEK = table.Column<int>(type: "int", nullable: true),
                    BBM_ART_FinnsAlltidHemma = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Behov_BOM_BBM_PK", x => new { x.BBM_User, x.BBM_ArtikelNr, x.BBM_Datum, x.BBM_BOM_OpNr, x.BBM_BOM_OpOrdNr });
                });

            migrationBuilder.CreateTable(
                name: "Bill_Of_Material_BOM",
                columns: table => new
                {
                    BOM_ArtikelNr = table.Column<long>(type: "bigint", nullable: false),
                    BOM_OpNr = table.Column<byte>(type: "tinyint", nullable: false),
                    BOM_OpOrdNr = table.Column<byte>(type: "tinyint", nullable: false),
                    BOM_IngArtikelNr = table.Column<long>(type: "bigint", nullable: true),
                    BOM_ART_IngArtikelNr = table.Column<long>(type: "bigint", nullable: true),
                    BOM_USR_Rsn = table.Column<long>(type: "bigint", nullable: true),
                    BOM_Kvant = table.Column<int>(type: "int", nullable: true),
                    BOM_ArtTyp = table.Column<int>(type: "int", nullable: true),
                    BOM_IngArtTyp = table.Column<int>(type: "int", nullable: true),
                    BOM_IngPris = table.Column<int>(type: "int", nullable: true),
                    BOM_Belopp = table.Column<int>(type: "int", nullable: true),
                    BOM_IngEnhet = table.Column<string>(type: "char(9)", unicode: false, fixedLength: true, maxLength: 9, nullable: true),
                    BOM_RecKvant = table.Column<int>(type: "int", nullable: true),
                    BOM_RecEnh = table.Column<byte>(type: "tinyint", nullable: true),
                    BOM_Anm = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    BOM_Memo = table.Column<string>(type: "text", nullable: true),
                    BOM_JustVeckodag = table.Column<byte>(type: "tinyint", nullable: true),
                    BOM_DateTimeStamp = table.Column<DateTime>(type: "datetime", nullable: true),
                    BOM_Sats = table.Column<int>(type: "int", nullable: true),
                    BOM_IngSats = table.Column<int>(type: "int", nullable: true),
                    BOM_Maltid = table.Column<byte>(type: "tinyint", nullable: true),
                    BOM_Matratt = table.Column<byte>(type: "tinyint", nullable: true),
                    BOM_USK_KvantitetForslag = table.Column<int>(type: "int", nullable: true),
                    BOM_BeloppIngFinns = table.Column<int>(type: "int", nullable: true),
                    BOM_BeloppFinns = table.Column<int>(type: "int", nullable: true),
                    BOM_IngkCal = table.Column<int>(type: "int", nullable: true),
                    BOM_kCal = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Bill_Of_Material_BOM_PK", x => new { x.BOM_ArtikelNr, x.BOM_OpNr, x.BOM_OpOrdNr });
                });

            migrationBuilder.CreateTable(
                name: "Blog_BLG",
                columns: table => new
                {
                    BLG_Rsn = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BLG_Datum = table.Column<DateTime>(type: "datetime", nullable: true),
                    BLG_Signatur = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    BLG_DatumUser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    BLG_Amne = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    BLG_OrgArtikelNr = table.Column<long>(type: "bigint", nullable: true),
                    BLG_Text = table.Column<string>(type: "text", nullable: true),
                    BLG_RelRsn = table.Column<long>(type: "bigint", nullable: true),
                    BLG_RelAmne = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    BLG_USR_Rsn = table.Column<long>(type: "bigint", nullable: true),
                    BLG_Gilla = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Blog_BLG_PK", x => x.BLG_Rsn);
                });

            migrationBuilder.CreateTable(
                name: "DagPlan_DAP",
                columns: table => new
                {
                    DAP_Rsn = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DAP_ArtikelNr = table.Column<long>(type: "bigint", nullable: true),
                    DAP_Datum = table.Column<DateTime>(type: "datetime", nullable: true),
                    DAP_Kvantitet = table.Column<int>(type: "int", nullable: true),
                    DAP_ArtTyp = table.Column<int>(type: "int", nullable: true),
                    DAP_FrTi = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    DAP_User = table.Column<long>(type: "bigint", nullable: true),
                    DAP_Dag = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DAP_Enhet = table.Column<string>(type: "char(9)", unicode: false, fixedLength: true, maxLength: 9, nullable: true),
                    DAP_SLD_Pris = table.Column<int>(type: "int", nullable: true),
                    DAP_SLD_Summa = table.Column<int>(type: "int", nullable: true),
                    DAP_Vecka = table.Column<int>(type: "int", nullable: true),
                    DAP_Manad = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DAP_ART_ArtikelNr = table.Column<long>(type: "bigint", nullable: true),
                    DAP_ArtikelNamn = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DAP_ImgTyp = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    DAP_AltBild = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DAP_LagerSaldo = table.Column<int>(type: "int", nullable: true),
                    DAP_Sats = table.Column<int>(type: "int", nullable: true),
                    DAP_InkopBered = table.Column<int>(type: "int", nullable: true),
                    DAP_Maltid = table.Column<byte>(type: "tinyint", nullable: true),
                    DAP_Matratt = table.Column<byte>(type: "tinyint", nullable: true),
                    DAP_Anm = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DAP_KLS_User = table.Column<long>(type: "bigint", nullable: true),
                    DAP_KLS_ArtikelNr = table.Column<long>(type: "bigint", nullable: true),
                    DAP_UddaVecka = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    DAP_ART_kCalFormula = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("DagPlan_DAP_PK", x => x.DAP_Rsn);
                });

            migrationBuilder.CreateTable(
                name: "DUMMY",
                columns: table => new
                {
                    DU_K1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    DU_BEN = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("DUMMY_PK", x => x.DU_K1);
                });

            migrationBuilder.CreateTable(
                name: "EmiR_MAIL_SMT",
                columns: table => new
                {
                    SMT_RSN = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SMT_RecipientsTo = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    SMT_RecipientsCC = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    SMT_Subject = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    SMT_MsgText = table.Column<string>(type: "text", nullable: true),
                    SMT_AttachFiles = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    SMT_Status = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    SMT_DateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    SMT_User = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("EmiR_MAIL_SMT_PK", x => x.SMT_RSN);
                });

            migrationBuilder.CreateTable(
                name: "ip2location_db5",
                columns: table => new
                {
                    ip_from = table.Column<long>(type: "bigint", nullable: true),
                    ip_to = table.Column<long>(type: "bigint", nullable: true),
                    country_code = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    country_name = table.Column<string>(type: "varchar(65)", unicode: false, maxLength: 65, nullable: true),
                    region_name = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true),
                    city_name = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true),
                    latitude = table.Column<double>(type: "float", nullable: true),
                    longitude = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "KalendarisktLagerSaldo_KLS",
                columns: table => new
                {
                    KLS_User = table.Column<long>(type: "bigint", nullable: false),
                    KLS_ArtikelNr = table.Column<long>(type: "bigint", nullable: false),
                    KLS_Datum = table.Column<DateTime>(type: "datetime", nullable: false),
                    KLS_RelUser = table.Column<long>(type: "bigint", nullable: true),
                    KLS_RelArtikelNr = table.Column<long>(type: "bigint", nullable: true),
                    KLS_RelDatum = table.Column<DateTime>(type: "datetime", nullable: true),
                    KLS_SLD_Forslag = table.Column<int>(type: "int", nullable: true),
                    KLS_ART_Losvikt = table.Column<int>(type: "int", nullable: true),
                    KLS_SatsLosvikt = table.Column<int>(type: "int", nullable: true),
                    KLS_LagerSaldo = table.Column<int>(type: "int", nullable: true),
                    KLS_IngSaldo = table.Column<int>(type: "int", nullable: true),
                    KLS_DAPIn = table.Column<int>(type: "int", nullable: true),
                    KLS_BOMUt = table.Column<int>(type: "int", nullable: true),
                    KLS_MinLager = table.Column<int>(type: "int", nullable: true),
                    KLS_AntBBM = table.Column<int>(type: "int", nullable: true),
                    KLS_KalSaldo = table.Column<int>(type: "int", nullable: true),
                    KLS_Behov = table.Column<int>(type: "int", nullable: true),
                    KLS_Forslag = table.Column<int>(type: "int", nullable: true),
                    KLS_KalSaldoUt = table.Column<int>(type: "int", nullable: true),
                    KLS_BehovRepl = table.Column<int>(type: "int", nullable: true),
                    KLS_BestDatum = table.Column<DateTime>(type: "datetime", nullable: true),
                    KLS_ART_Ledtid = table.Column<long>(type: "bigint", nullable: true),
                    KLS_Dag = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    KLS_Manad = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    KLS_Vecka = table.Column<int>(type: "int", nullable: true),
                    KLS_Enhet = table.Column<string>(type: "char(9)", unicode: false, fixedLength: true, maxLength: 9, nullable: true),
                    KLS_ForslagSEK = table.Column<int>(type: "int", nullable: true),
                    KLS_BehovSEK = table.Column<int>(type: "int", nullable: true),
                    KLS_ArtTyp = table.Column<int>(type: "int", nullable: true),
                    KLS_BehovTot = table.Column<int>(type: "int", nullable: true),
                    KLS_KlientNamn = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    KLS_PubliceraRelKonstant = table.Column<bool>(type: "bit", nullable: true),
                    KLS_TillvFobrukatNu = table.Column<int>(type: "int", nullable: true),
                    KLS_TillvLagerNu = table.Column<int>(type: "int", nullable: true),
                    KLS_DateStamp = table.Column<DateTime>(type: "datetime", nullable: true),
                    KLS_DaglForbr = table.Column<int>(type: "int", nullable: true),
                    KLS_SLD_DaglForbr = table.Column<int>(type: "int", nullable: true),
                    KLS_ART_ART_ArtikelNr = table.Column<long>(type: "bigint", nullable: true),
                    KLS_ART_Inkop = table.Column<int>(type: "int", nullable: false),
                    KLS_ART_InkopEnhet = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    KLS_Forslag_OK = table.Column<byte>(type: "tinyint", nullable: true),
                    KLS_GramPerDl = table.Column<int>(type: "int", nullable: true),
                    KLS_GramPerSt = table.Column<int>(type: "int", nullable: true),
                    KLS_ForslagInkopEnhet = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    KLS_ForslagInkopSEK = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    KLS_KalSaldoStr = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    KLS_BehovInkopEnhet = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    KLS_BOMUtInkopEnhet = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    KLS_BehovTotInkopEnhet = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    KLS_KalSaldoUtInkopEnhet = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    KLS_Rest_FattasKvar = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    KLS_Extra = table.Column<int>(type: "int", nullable: true),
                    KLS_ExtraSt = table.Column<int>(type: "int", nullable: true),
                    KLS_SaldoSt = table.Column<int>(type: "int", nullable: true),
                    KLS_ProduktArtikelNamn = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    KLS_UddaVecka = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    KLS_ART_Faktor = table.Column<int>(type: "int", nullable: true),
                    KLS_ART_Sats = table.Column<int>(type: "int", nullable: true),
                    KLS_ART_Pris = table.Column<int>(type: "int", nullable: true),
                    KLS_ART_PrisFrp = table.Column<int>(type: "int", nullable: true),
                    KLS_ART_PrisDatum = table.Column<DateTime>(type: "datetime", nullable: true),
                    KLS_ART_AnsvUser = table.Column<long>(type: "bigint", nullable: true),
                    KLS_SistaKLS = table.Column<int>(type: "int", nullable: true),
                    KLS_VG = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    KLS_ART_kCalFormula = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("KalendarisktLagerSaldo_KLS_PK", x => new { x.KLS_User, x.KLS_ArtikelNr, x.KLS_Datum });
                });

            migrationBuilder.CreateTable(
                name: "Klient_USK",
                columns: table => new
                {
                    USK_Rsn = table.Column<long>(type: "bigint", nullable: false),
                    USK_Namn = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    USK_KvantitetForslag = table.Column<int>(type: "int", nullable: true),
                    USK_LagerSEK = table.Column<int>(type: "int", nullable: true),
                    USK_BristSEK = table.Column<int>(type: "int", nullable: true),
                    USK_KostnadSEK = table.Column<int>(type: "int", nullable: true),
                    USK_HandlarMa = table.Column<byte>(type: "tinyint", nullable: true),
                    USK_HandlarTi = table.Column<byte>(type: "tinyint", nullable: true),
                    USK_HandlarOn = table.Column<byte>(type: "tinyint", nullable: true),
                    USK_HandlarTo = table.Column<byte>(type: "tinyint", nullable: true),
                    USK_HandlarFr = table.Column<byte>(type: "tinyint", nullable: true),
                    USK_HandlarLo = table.Column<byte>(type: "tinyint", nullable: true),
                    USK_HandlarSo = table.Column<byte>(type: "tinyint", nullable: true),
                    USK_Handlar = table.Column<byte>(type: "tinyint", nullable: true),
                    USK_LicensBetaldToM = table.Column<DateTime>(type: "datetime", nullable: true),
                    USK_LicensBetaldStatus = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    USK_AntDAP = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Klient_USK_PK", x => x.USK_Rsn);
                });

            migrationBuilder.CreateTable(
                name: "SkapaKonto_SKO",
                columns: table => new
                {
                    SKO_RSN = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SKO_NAMN = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    SKO_SIGNATUR = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    SKO_EMAIL = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    SKO_USERID = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    SKO_PWD1 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    SKO_PWD2 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    SKO_MEDDELANDE = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("SkapaKonto_SKO_PK", x => x.SKO_RSN);
                });

            migrationBuilder.CreateTable(
                name: "Transaktion_TRN",
                columns: table => new
                {
                    TRN_DateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    TRN_USR_Rsn = table.Column<long>(type: "bigint", nullable: true),
                    TRN_USK_Rsn = table.Column<long>(type: "bigint", nullable: true),
                    TRN_USR_Signatur = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TRN_USK_Namn = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TRN_Sok = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    TRN_RemoteAddr = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TRN_RemoteStad = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true),
                    TRN_RemoteRegion = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true),
                    TRN_RemoteLandkod = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Transaktion_TRN_PK", x => x.TRN_DateTime);
                });

            migrationBuilder.CreateTable(
                name: "Z_AltBild",
                columns: table => new
                {
                    Storedpfu = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Z_AltBild_PK", x => x.Storedpfu);
                });

            migrationBuilder.CreateTable(
                name: "Z_ART_Enhet",
                columns: table => new
                {
                    Storedpfu = table.Column<string>(type: "char(9)", unicode: false, fixedLength: true, maxLength: 9, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Z_ART_Enhet_PK", x => x.Storedpfu);
                });

            migrationBuilder.CreateTable(
                name: "Z_ART_Grupp",
                columns: table => new
                {
                    Storedpfu = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false),
                    Displayed = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Z_ART_Grupp_PK", x => x.Storedpfu);
                });

            migrationBuilder.CreateTable(
                name: "Z_ART_Lagring",
                columns: table => new
                {
                    Storedpfu = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    Displayed = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Z_ART_Lagring_PK", x => x.Storedpfu);
                });

            migrationBuilder.CreateTable(
                name: "Z_ART_RecEnh",
                columns: table => new
                {
                    Storedpfu = table.Column<byte>(type: "tinyint", nullable: false),
                    Displayed = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Z_ART_RecEnh_PK", x => x.Storedpfu);
                });

            migrationBuilder.CreateTable(
                name: "Z_ART_Typ",
                columns: table => new
                {
                    Storedpfu = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false),
                    Displayed = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Z_ART_Typ_PK", x => x.Storedpfu);
                });

            migrationBuilder.CreateTable(
                name: "Z_BeredInkop",
                columns: table => new
                {
                    Storedpfu = table.Column<byte>(type: "tinyint", nullable: false),
                    Displayed = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Z_BeredInkop_PK", x => x.Storedpfu);
                });

            migrationBuilder.CreateTable(
                name: "Z_BristViaSMS",
                columns: table => new
                {
                    Storedpfu = table.Column<byte>(type: "tinyint", nullable: false),
                    Displayed = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Z_BristViaSMS_PK", x => x.Storedpfu);
                });

            migrationBuilder.CreateTable(
                name: "Z_Datum",
                columns: table => new
                {
                    Datum = table.Column<DateTime>(type: "datetime", nullable: false),
                    Dag = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Z_Datum_PK", x => x.Datum);
                });

            migrationBuilder.CreateTable(
                name: "Z_Handlar",
                columns: table => new
                {
                    Storedpfu = table.Column<byte>(type: "tinyint", nullable: false),
                    Displayed = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Z_Handlar_PK", x => x.Storedpfu);
                });

            migrationBuilder.CreateTable(
                name: "Z_HI",
                columns: table => new
                {
                    Storedpfu = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Displayed = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Z_HI_PK", x => x.Storedpfu);
                });

            migrationBuilder.CreateTable(
                name: "Z_Ja",
                columns: table => new
                {
                    Storedpfu = table.Column<byte>(type: "tinyint", nullable: false),
                    Displayed = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Z_Ja_PK", x => x.Storedpfu);
                });

            migrationBuilder.CreateTable(
                name: "Z_Kat",
                columns: table => new
                {
                    Storedpfu = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: false),
                    Displayed = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Z_Kat_PK", x => x.Storedpfu);
                });

            migrationBuilder.CreateTable(
                name: "Z_Maltid",
                columns: table => new
                {
                    Storedpfu = table.Column<byte>(type: "tinyint", nullable: false),
                    Displayed = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Z_Maltid_PK", x => x.Storedpfu);
                });

            migrationBuilder.CreateTable(
                name: "Z_Matratt",
                columns: table => new
                {
                    Storedpfu = table.Column<byte>(type: "tinyint", nullable: false),
                    Displayed = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Z_Matratt_PK", x => x.Storedpfu);
                });

            migrationBuilder.CreateTable(
                name: "Z_NejJa",
                columns: table => new
                {
                    Storedpfu = table.Column<byte>(type: "tinyint", nullable: false),
                    Displayed = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Z_NejJa_PK", x => x.Storedpfu);
                });

            migrationBuilder.CreateTable(
                name: "Z_Plandag",
                columns: table => new
                {
                    Storedpfu = table.Column<byte>(type: "tinyint", nullable: false),
                    Displayed = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Z_Plandag_PK", x => x.Storedpfu);
                });

            migrationBuilder.CreateTable(
                name: "Z_Steg",
                columns: table => new
                {
                    Storedpfu = table.Column<byte>(type: "tinyint", nullable: false),
                    Displayed = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Z_Steg_PK", x => x.Storedpfu);
                });

            migrationBuilder.CreateTable(
                name: "Z_Veckodag",
                columns: table => new
                {
                    Storedpfu = table.Column<byte>(type: "tinyint", nullable: false),
                    Displayed = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Z_Veckodag_PK", x => x.Storedpfu);
                });

            migrationBuilder.CreateTable(
                name: "Z_VG",
                columns: table => new
                {
                    Storedpfu = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    DisplayedVG = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Z_VG_PK", x => x.Storedpfu);
                });

            migrationBuilder.CreateIndex(
                name: "Artikel_ART_AK1",
                table: "Artikel_ART",
                column: "ART_ART_ArtikelNr");

            migrationBuilder.CreateIndex(
                name: "Artikel_ART_AK2",
                table: "Artikel_ART",
                column: "ART_USR_Rsn");

            migrationBuilder.CreateIndex(
                name: "AK_ArtikelNr",
                table: "Behov_BOM_BBM",
                column: "BBM_ArtikelNr");

            migrationBuilder.CreateIndex(
                name: "AK_BBM2",
                table: "Behov_BOM_BBM",
                columns: new[] { "BBM_IngUser", "BBM_IngDatum", "BBM_IngArtikelNr" });

            migrationBuilder.CreateIndex(
                name: "AK_IngArtikelNr",
                table: "Behov_BOM_BBM",
                column: "BBM_IngArtikelNr");

            migrationBuilder.CreateIndex(
                name: "AK1",
                table: "Bill_Of_Material_BOM",
                column: "BOM_IngArtikelNr");

            migrationBuilder.CreateIndex(
                name: "AK2",
                table: "Bill_Of_Material_BOM",
                column: "BOM_ArtikelNr");

            migrationBuilder.CreateIndex(
                name: "AK_AmneDatum",
                table: "Blog_BLG",
                columns: new[] { "BLG_Amne", "BLG_Datum" });

            migrationBuilder.CreateIndex(
                name: "AK_DAtumUser",
                table: "Blog_BLG",
                column: "BLG_DatumUser");

            migrationBuilder.CreateIndex(
                name: "AK_OrgArtnr",
                table: "Blog_BLG",
                columns: new[] { "BLG_OrgArtikelNr", "BLG_Rsn" });

            migrationBuilder.CreateIndex(
                name: "AK_Rsn_RelRsn",
                table: "Blog_BLG",
                columns: new[] { "BLG_Rsn", "BLG_RelRsn" });

            migrationBuilder.CreateIndex(
                name: "AK_ART_ArtikelNr",
                table: "DagPlan_DAP",
                column: "DAP_ART_ArtikelNr");

            migrationBuilder.CreateIndex(
                name: "AK_ArtikelNr",
                table: "DagPlan_DAP",
                column: "DAP_ArtikelNr");

            migrationBuilder.CreateIndex(
                name: "AK_USR",
                table: "DagPlan_DAP",
                column: "DAP_User");

            migrationBuilder.CreateIndex(
                name: "idx_ip_from",
                table: "ip2location_db5",
                column: "ip_from");

            migrationBuilder.CreateIndex(
                name: "idx_ip_from_to",
                table: "ip2location_db5",
                columns: new[] { "ip_from", "ip_to" });

            migrationBuilder.CreateIndex(
                name: "idx_ip_to",
                table: "ip2location_db5",
                column: "ip_to");

            migrationBuilder.CreateIndex(
                name: "AK_ART_ART_ArtikelNr",
                table: "KalendarisktLagerSaldo_KLS",
                column: "KLS_ART_ART_ArtikelNr");

            migrationBuilder.CreateIndex(
                name: "AK_ArtikelNr",
                table: "KalendarisktLagerSaldo_KLS",
                column: "KLS_ArtikelNr");

            migrationBuilder.CreateIndex(
                name: "AK_Rel_KLS",
                table: "KalendarisktLagerSaldo_KLS",
                columns: new[] { "KLS_RelUser", "KLS_RelArtikelNr", "KLS_RelDatum" });

            migrationBuilder.CreateIndex(
                name: "AK_USR",
                table: "KalendarisktLagerSaldo_KLS",
                columns: new[] { "KLS_User", "KLS_Datum" });

            migrationBuilder.CreateIndex(
                name: "UQ__Klient_U__80C58B6474E2CC72",
                table: "Klient_USK",
                column: "USK_Namn",
                unique: true,
                filter: "[USK_Namn] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Artikel_ART");

            migrationBuilder.DropTable(
                name: "Batch_BAT");

            migrationBuilder.DropTable(
                name: "Behov_BOM_BBM");

            migrationBuilder.DropTable(
                name: "Bill_Of_Material_BOM");

            migrationBuilder.DropTable(
                name: "Blog_BLG");

            migrationBuilder.DropTable(
                name: "DagPlan_DAP");

            migrationBuilder.DropTable(
                name: "DUMMY");

            migrationBuilder.DropTable(
                name: "EmiR_MAIL_SMT");

            migrationBuilder.DropTable(
                name: "ip2location_db5");

            migrationBuilder.DropTable(
                name: "KalendarisktLagerSaldo_KLS");

            migrationBuilder.DropTable(
                name: "Klient_USK");

            migrationBuilder.DropTable(
                name: "SkapaKonto_SKO");

            migrationBuilder.DropTable(
                name: "Transaktion_TRN");

            migrationBuilder.DropTable(
                name: "Z_AltBild");

            migrationBuilder.DropTable(
                name: "Z_ART_Enhet");

            migrationBuilder.DropTable(
                name: "Z_ART_Grupp");

            migrationBuilder.DropTable(
                name: "Z_ART_Lagring");

            migrationBuilder.DropTable(
                name: "Z_ART_RecEnh");

            migrationBuilder.DropTable(
                name: "Z_ART_Typ");

            migrationBuilder.DropTable(
                name: "Z_BeredInkop");

            migrationBuilder.DropTable(
                name: "Z_BristViaSMS");

            migrationBuilder.DropTable(
                name: "Z_Datum");

            migrationBuilder.DropTable(
                name: "Z_Handlar");

            migrationBuilder.DropTable(
                name: "Z_HI");

            migrationBuilder.DropTable(
                name: "Z_Ja");

            migrationBuilder.DropTable(
                name: "Z_Kat");

            migrationBuilder.DropTable(
                name: "Z_Maltid");

            migrationBuilder.DropTable(
                name: "Z_Matratt");

            migrationBuilder.DropTable(
                name: "Z_NejJa");

            migrationBuilder.DropTable(
                name: "Z_Plandag");

            migrationBuilder.DropTable(
                name: "Z_Steg");

            migrationBuilder.DropTable(
                name: "Z_Veckodag");

            migrationBuilder.DropTable(
                name: "Z_VG");
        }
    }
}
