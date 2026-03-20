using System;
using System.Collections.Generic;
using Matplan.EntityModels.Models;
using Matplan.Infrastructure.IdentityModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Matplan.Infrastructure.Data;

public partial class MatplanDBContext : IdentityDbContext<User_USR, IdentityRole, string>
{
    //public MatplanDBContext()
    //{
    //}

    public MatplanDBContext(DbContextOptions<MatplanDBContext> options)
        : base(options)
    {
    }


    public virtual DbSet<Artikel_ART> Artikel_ART { get; set; }

    public virtual DbSet<Batch_BAT> Batch_BAT { get; set; }

    public virtual DbSet<Behov_BOM_BBM> Behov_BOM_BBM { get; set; }

    public virtual DbSet<Bill_Of_Material_BOM> Bill_Of_Material_BOM { get; set; }

    public virtual DbSet<Blog_BLG> Blog_BLG { get; set; }

    public virtual DbSet<DUMMY> DUMMY { get; set; }

    public virtual DbSet<DagPlan_DAP> DagPlan_DAP { get; set; }

    public virtual DbSet<EmiR_MAIL_SMT> EmiR_MAIL_SMT { get; set; }

    public virtual DbSet<KalendarisktLagerSaldo_KLS> KalendarisktLagerSaldo_KLS { get; set; }

    public virtual DbSet<Klient_USK> Klient_USK { get; set; }

    public virtual DbSet<SkapaKonto_SKO> SkapaKonto_SKO { get; set; }

    public virtual DbSet<Transaktion_TRN> Transaktion_TRN { get; set; }

    public virtual DbSet<User_USR> User_USR { get; set; }

    public virtual DbSet<Z_ART_Enhet> Z_ART_Enhet { get; set; }

    public virtual DbSet<Z_ART_Grupp> Z_ART_Grupp { get; set; }

    public virtual DbSet<Z_ART_Lagring> Z_ART_Lagring { get; set; }

    public virtual DbSet<Z_ART_RecEnh> Z_ART_RecEnh { get; set; }

    public virtual DbSet<Z_ART_Typ> Z_ART_Typ { get; set; }

    public virtual DbSet<Z_AltBild> Z_AltBild { get; set; }

    public virtual DbSet<Z_BeredInkop> Z_BeredInkop { get; set; }

    public virtual DbSet<Z_BristViaSMS> Z_BristViaSMS { get; set; }

    public virtual DbSet<Z_Datum> Z_Datum { get; set; }

    public virtual DbSet<Z_HI> Z_HI { get; set; }

    public virtual DbSet<Z_Handlar> Z_Handlar { get; set; }

    public virtual DbSet<Z_Ja> Z_Ja { get; set; }

    public virtual DbSet<Z_Kat> Z_Kat { get; set; }

    public virtual DbSet<Z_Maltid> Z_Maltid { get; set; }

    public virtual DbSet<Z_Matratt> Z_Matratt { get; set; }

    public virtual DbSet<Z_NejJa> Z_NejJa { get; set; }

    public virtual DbSet<Z_Plandag> Z_Plandag { get; set; }

    public virtual DbSet<Z_Steg> Z_Steg { get; set; }

    public virtual DbSet<Z_VG> Z_VG { get; set; }

    public virtual DbSet<Z_Veckodag> Z_Veckodag { get; set; }

    public virtual DbSet<ip2location_db5> ip2location_db5 { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<IdentityPasskeyData>().HasNoKey();

        modelBuilder.Entity<Artikel_ART>(entity =>
        {
            entity.HasKey(e => e.ART_ArtikelNr).HasName("Artikel_ART_PK");

            entity.HasIndex(e => e.ART_ART_ArtikelNr, "Artikel_ART_AK1");

            entity.HasIndex(e => e.ART_USR_Rsn, "Artikel_ART_AK2");

            entity.Property(e => e.ART_AgentDatum).HasColumnType("datetime");
            entity.Property(e => e.ART_AltBild)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ART_ArtikelNamn)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ART_BastForeDatum).HasColumnType("datetime");
            entity.Property(e => e.ART_DateMod).HasColumnType("datetime");
            entity.Property(e => e.ART_DateNy).HasColumnType("datetime");
            entity.Property(e => e.ART_DateUppdat).HasColumnType("datetime");
            entity.Property(e => e.ART_Enhet)
                .HasMaxLength(9)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ART_FlashAdd)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ART_Grupp)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.ART_HI)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ART_Image).HasColumnType("image");
            entity.Property(e => e.ART_ImgTyp)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.ART_InkopEnhet)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ART_Kat)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ART_KlientNamn)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ART_LagerSaldoSt)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ART_Lagring)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ART_Memo).HasColumnType("text");
            entity.Property(e => e.ART_PrisDatum).HasColumnType("datetime");
            entity.Property(e => e.ART_ProduktArtikelNamn)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ART_Sok)
                .HasMaxLength(2500)
                .IsUnicode(false);
            entity.Property(e => e.ART_Sok_Ravaror)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ART_URL)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.ART_URL_Link)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ART_URL_Text)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ART_Upload).HasColumnType("text");
            entity.Property(e => e.ART_UserMod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ART_UserNy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ART_VG)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Batch_BAT>(entity =>
        {
            entity.HasKey(e => e.BAT_Id).HasName("Batch_BAT_PK");

            entity.Property(e => e.BAT_Id).ValueGeneratedNever();
            entity.Property(e => e.BAT_Namn)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BAT_QUALITY).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.BAT_SERVERPATH)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.BAT_SimDatum).HasColumnType("datetime");
            entity.Property(e => e.BAT_URL)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Behov_BOM_BBM>(entity =>
        {
            entity.HasKey(e => new { e.BBM_User, e.BBM_ArtikelNr, e.BBM_Datum, e.BBM_BOM_OpNr, e.BBM_BOM_OpOrdNr }).HasName("Behov_BOM_BBM_PK");

            entity.HasIndex(e => e.BBM_ArtikelNr, "AK_ArtikelNr");

            entity.HasIndex(e => new { e.BBM_IngUser, e.BBM_IngDatum, e.BBM_IngArtikelNr }, "AK_BBM2");

            entity.HasIndex(e => e.BBM_IngArtikelNr, "AK_IngArtikelNr");

            entity.Property(e => e.BBM_Datum).HasColumnType("datetime");
            entity.Property(e => e.BBM_IngDatum).HasColumnType("datetime");
        });

        modelBuilder.Entity<Bill_Of_Material_BOM>(entity =>
        {
            entity.HasKey(e => new { e.BOM_ArtikelNr, e.BOM_OpNr, e.BOM_OpOrdNr }).HasName("Bill_Of_Material_BOM_PK");

            entity.HasIndex(e => e.BOM_IngArtikelNr, "AK1");

            entity.HasIndex(e => e.BOM_ArtikelNr, "AK2");

            entity.Property(e => e.BOM_Anm)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BOM_DateTimeStamp).HasColumnType("datetime");
            entity.Property(e => e.BOM_IngEnhet)
                .HasMaxLength(9)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.BOM_Memo).HasColumnType("text");
        });

        modelBuilder.Entity<Blog_BLG>(entity =>
        {
            entity.HasKey(e => e.BLG_Rsn).HasName("Blog_BLG_PK");

            entity.HasIndex(e => new { e.BLG_Amne, e.BLG_Datum }, "AK_AmneDatum");

            entity.HasIndex(e => e.BLG_DatumUser, "AK_DAtumUser");

            entity.HasIndex(e => new { e.BLG_OrgArtikelNr, e.BLG_Rsn }, "AK_OrgArtnr");

            entity.HasIndex(e => new { e.BLG_Rsn, e.BLG_RelRsn }, "AK_Rsn_RelRsn");

            entity.Property(e => e.BLG_Amne)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BLG_Datum).HasColumnType("datetime");
            entity.Property(e => e.BLG_DatumUser)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BLG_RelAmne)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BLG_Signatur)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BLG_Text).HasColumnType("text");
        });

        modelBuilder.Entity<DUMMY>(entity =>
        {
            entity.HasKey(e => e.DU_K1).HasName("DUMMY_PK");

            entity.Property(e => e.DU_K1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DU_BEN)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DagPlan_DAP>(entity =>
        {
            entity.HasKey(e => e.DAP_Rsn).HasName("DagPlan_DAP_PK");

            entity.HasIndex(e => e.DAP_ART_ArtikelNr, "AK_ART_ArtikelNr");

            entity.HasIndex(e => e.DAP_ArtikelNr, "AK_ArtikelNr");

            entity.HasIndex(e => e.DAP_User, "AK_USR");

            entity.Property(e => e.DAP_AltBild)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DAP_Anm)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DAP_ArtikelNamn)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DAP_Dag)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DAP_Datum).HasColumnType("datetime");
            entity.Property(e => e.DAP_Enhet)
                .HasMaxLength(9)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DAP_FrTi)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DAP_ImgTyp)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.DAP_Manad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DAP_UddaVecka)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<EmiR_MAIL_SMT>(entity =>
        {
            entity.HasKey(e => e.SMT_RSN).HasName("EmiR_MAIL_SMT_PK");

            entity.Property(e => e.SMT_AttachFiles)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.SMT_DateTime).HasColumnType("datetime");
            entity.Property(e => e.SMT_MsgText).HasColumnType("text");
            entity.Property(e => e.SMT_RecipientsCC)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.SMT_RecipientsTo)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.SMT_Status)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.SMT_Subject)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.SMT_User)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<KalendarisktLagerSaldo_KLS>(entity =>
        {
            entity.HasKey(e => new { e.KLS_User, e.KLS_ArtikelNr, e.KLS_Datum }).HasName("KalendarisktLagerSaldo_KLS_PK");

            entity.HasIndex(e => e.KLS_ART_ART_ArtikelNr, "AK_ART_ART_ArtikelNr");

            entity.HasIndex(e => e.KLS_ArtikelNr, "AK_ArtikelNr");

            entity.HasIndex(e => new { e.KLS_RelUser, e.KLS_RelArtikelNr, e.KLS_RelDatum }, "AK_Rel_KLS");

            entity.HasIndex(e => new { e.KLS_User, e.KLS_Datum }, "AK_USR");

            entity.Property(e => e.KLS_Datum).HasColumnType("datetime");
            entity.Property(e => e.KLS_ART_InkopEnhet)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.KLS_ART_PrisDatum).HasColumnType("datetime");
            entity.Property(e => e.KLS_BOMUtInkopEnhet)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.KLS_BehovInkopEnhet)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.KLS_BehovTotInkopEnhet)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.KLS_BestDatum).HasColumnType("datetime");
            entity.Property(e => e.KLS_Dag)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.KLS_DateStamp).HasColumnType("datetime");
            entity.Property(e => e.KLS_Enhet)
                .HasMaxLength(9)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.KLS_ForslagInkopEnhet)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.KLS_ForslagInkopSEK)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.KLS_KalSaldoStr)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.KLS_KalSaldoUtInkopEnhet)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.KLS_KlientNamn)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.KLS_Manad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.KLS_ProduktArtikelNamn)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.KLS_RelDatum).HasColumnType("datetime");
            entity.Property(e => e.KLS_Rest_FattasKvar)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.KLS_UddaVecka)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.KLS_VG)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Klient_USK>(entity =>
        {
            entity.HasKey(e => e.USK_Rsn).HasName("Klient_USK_PK");

            entity.HasIndex(e => e.USK_Namn, "UQ__Klient_U__80C58B6474E2CC72").IsUnique();

            entity.Property(e => e.USK_Rsn).ValueGeneratedNever();
            entity.Property(e => e.USK_LicensBetaldStatus)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.USK_LicensBetaldToM).HasColumnType("datetime");
            entity.Property(e => e.USK_Namn)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SkapaKonto_SKO>(entity =>
        {
            entity.HasKey(e => e.SKO_RSN).HasName("SkapaKonto_SKO_PK");

            entity.Property(e => e.SKO_EMAIL)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SKO_MEDDELANDE).HasColumnType("text");
            entity.Property(e => e.SKO_NAMN)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SKO_PWD1)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.SKO_PWD2)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.SKO_SIGNATUR)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SKO_USERID)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Transaktion_TRN>(entity =>
        {
            entity.HasKey(e => e.TRN_DateTime).HasName("Transaktion_TRN_PK");

            entity.Property(e => e.TRN_DateTime).HasColumnType("datetime");
            entity.Property(e => e.TRN_RemoteAddr)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TRN_RemoteLandkod)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.TRN_RemoteRegion)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.TRN_RemoteStad)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.TRN_Sok)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.TRN_USK_Namn)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TRN_USR_Signatur)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<User_USR>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("User_USR_PK");

            entity.HasIndex(e => e.USR_USK_Rsn, "AK_USK_Rsn");

            entity.HasIndex(e => e.USR_Email, "UQ__User_USR__8A8468E36E91C2DF").IsUnique();

            entity.HasIndex(e => e.USR_Login, "UQ__User_USR__E7ECFE4A277B7037").IsUnique();

            entity.Property(e => e.USR_Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.USR_Login)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.USR_MailKlockSlag)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.USR_Mail_Skickat)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.USR_Mail_Skickat_Text)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.USR_MobilTelNr)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.USR_Passord)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.USR_Passord1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.USR_Roll)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.USR_SMSKlockslag)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.USR_SMS_Skickat)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.USR_SMS_Skickat_Text)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.USR_Signatur)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.USR_Timestamp).HasColumnType("datetime");
        });

        modelBuilder.Entity<Z_ART_Enhet>(entity =>
        {
            entity.HasKey(e => e.Storedpfu).HasName("Z_ART_Enhet_PK");

            entity.Property(e => e.Storedpfu)
                .HasMaxLength(9)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Z_ART_Grupp>(entity =>
        {
            entity.HasKey(e => e.Storedpfu).HasName("Z_ART_Grupp_PK");

            entity.Property(e => e.Storedpfu)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Displayed)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Z_ART_Lagring>(entity =>
        {
            entity.HasKey(e => e.Storedpfu).HasName("Z_ART_Lagring_PK");

            entity.Property(e => e.Storedpfu)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Displayed)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Z_ART_RecEnh>(entity =>
        {
            entity.HasKey(e => e.Storedpfu).HasName("Z_ART_RecEnh_PK");

            entity.Property(e => e.Displayed)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Z_ART_Typ>(entity =>
        {
            entity.HasKey(e => e.Storedpfu).HasName("Z_ART_Typ_PK");

            entity.Property(e => e.Storedpfu)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Displayed)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Z_AltBild>(entity =>
        {
            entity.HasKey(e => e.Storedpfu).HasName("Z_AltBild_PK");

            entity.Property(e => e.Storedpfu)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Z_BeredInkop>(entity =>
        {
            entity.HasKey(e => e.Storedpfu).HasName("Z_BeredInkop_PK");

            entity.Property(e => e.Displayed)
                .HasMaxLength(5)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Z_BristViaSMS>(entity =>
        {
            entity.HasKey(e => e.Storedpfu).HasName("Z_BristViaSMS_PK");

            entity.Property(e => e.Displayed)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Z_Datum>(entity =>
        {
            entity.HasKey(e => e.Datum).HasName("Z_Datum_PK");

            entity.Property(e => e.Datum).HasColumnType("datetime");
            entity.Property(e => e.Dag)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Z_HI>(entity =>
        {
            entity.HasKey(e => e.Storedpfu).HasName("Z_HI_PK");

            entity.Property(e => e.Storedpfu)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Displayed)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Z_Handlar>(entity =>
        {
            entity.HasKey(e => e.Storedpfu).HasName("Z_Handlar_PK");

            entity.Property(e => e.Displayed)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Z_Ja>(entity =>
        {
            entity.HasKey(e => e.Storedpfu).HasName("Z_Ja_PK");

            entity.Property(e => e.Displayed)
                .HasMaxLength(3)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Z_Kat>(entity =>
        {
            entity.HasKey(e => e.Storedpfu).HasName("Z_Kat_PK");

            entity.Property(e => e.Storedpfu)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.Displayed)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Z_Maltid>(entity =>
        {
            entity.HasKey(e => e.Storedpfu).HasName("Z_Maltid_PK");

            entity.Property(e => e.Displayed)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Z_Matratt>(entity =>
        {
            entity.HasKey(e => e.Storedpfu).HasName("Z_Matratt_PK");

            entity.Property(e => e.Displayed)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Z_NejJa>(entity =>
        {
            entity.HasKey(e => e.Storedpfu).HasName("Z_NejJa_PK");

            entity.Property(e => e.Displayed)
                .HasMaxLength(3)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Z_Plandag>(entity =>
        {
            entity.HasKey(e => e.Storedpfu).HasName("Z_Plandag_PK");

            entity.Property(e => e.Displayed)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Z_Steg>(entity =>
        {
            entity.HasKey(e => e.Storedpfu).HasName("Z_Steg_PK");

            entity.Property(e => e.Displayed)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Z_VG>(entity =>
        {
            entity.HasKey(e => e.Storedpfu).HasName("Z_VG_PK");

            entity.Property(e => e.Storedpfu)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DisplayedVG)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Z_Veckodag>(entity =>
        {
            entity.HasKey(e => e.Storedpfu).HasName("Z_Veckodag_PK");

            entity.Property(e => e.Displayed)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ip2location_db5>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.ip_from, "idx_ip_from");

            entity.HasIndex(e => new { e.ip_from, e.ip_to }, "idx_ip_from_to");

            entity.HasIndex(e => e.ip_to, "idx_ip_to");

            entity.Property(e => e.city_name)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.country_code)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.country_name)
                .HasMaxLength(65)
                .IsUnicode(false);
            entity.Property(e => e.region_name)
                .HasMaxLength(128)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
