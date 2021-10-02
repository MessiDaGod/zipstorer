using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.IO;
using System.Text;

namespace Test
{
    [TestClass]
    public partial class UnitTestFolder : ZipDir
    {
        public string NewFileName { get; set; }
        public string NewFolderName { get; set; }

        [ClassInitialize]
        public static void Initialize(TestContext test)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        }

        public void YardiFolderDownload()
        {
            ZipDir[] dirArray = new ZipDir[297]
            {
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\CP_CO_lease_civilian.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\SDFH\LMH_FD_SDFH_executivehome_0219.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\SDFH\LMH_FD_SDFH_historic_0219.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\CP_QU_construction.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\CPEN_LBP_FH.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\ECFH\LMH_FD_ECFH_recp_0219.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\ECFH\LMH_FD_ECFH_ordinance_0219.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MAMFC\MA_I_II_asbestos_Yorktown.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\JBLM\FD_JBLM_All_Crime-Free.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MASD\MASD_inventory.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MAMFC\MA_I_II_LBP_annapolis.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\lmh_fd_risk.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\Window_petty_officer.pdf")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\SDFH\LMH_FD_SDFH_landuse_0219.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\SDFH\LMH_FD_SDFH_mold_0219.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\CP_CO_asbestos.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\CPEN_Lease_civilian.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\lmh_fd_cp_yuma_land_use_map.pdf")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\ECFH\LMH_FD_ECFH_historic_0219.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\LMH_FD_SDFH Terrace District ACM Addendum.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\CP_RD_LBP.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\LMH_FD_CP_AL_equipment.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\LMH_FD_Lemoore LBP Disclosure.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MASD\MASD_LBP_NA.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MASD\MASD_recp.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MASD\MASD_satellite.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\CPQH_recp.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\ECFH\LMH_FD_ECFH_assistedanimal_0219.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\LMH_FD_Admiral Hartman LBP Disclosure.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\LMH_FD_NASNI LBP Disclosure.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\LMH_FD_CP_KS_community.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MAMFC\MA_I_II_lease.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MASD\MASD_LBP_NO.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\CPEN_LBP_SLR.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\JBLM\FD_JBLM_historical.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\ECFH\LMH_FD_ECFH_asbestos_0219.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\ECFH\LMH_FD_ECFH_exechome_0219.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\JBLM\FD_JBLM_Towncenter_BBQ.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MAMFC\MA_I_II_asbestos_PR.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\JBLM\FD_JBLM_Fire_Safety_2.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\CPQH_inventory.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\lmh_fd_cp_yuma_construction.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\LMH_FD_CP_YUMA_land_use.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\ECFH\LMH_FD_ECFH prop6506518.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\JBLM\LMH_FD_JBLM_LBP_PAMPHLET_2018.pdf")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\LMH_FD_SDFH_CIVILIAN_LEASE.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\CP_CO_lease.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\CPEN_asbestos_SM.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\LMH_FD_CP_YUMA_community.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MASD\MASD_LBP_Arlington.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\CP_QU_lbp.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\CPEN_community.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MASD\MASD_community_executive.pdf")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\JBLM\FD_JBLM_All_Fire_safety_briefing.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MAMFC\MA_I_II_asbestos_IH.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\JBLM\FD_JBLM_ALL_resident_handbook.docx")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\CPQH_construction.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\ECFH\LMH_FD_ECFH_Lease_0219.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MASD\MASD_asbestos_potomac.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\FSH\FD_SAMH_TUB_SINK.DOC")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MAMFC\MA_I_II_inventory.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MAMFC\MA_LEJ_recp.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\CPEN_asbestos_mountain.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\CP_QU_pets.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\ECFH\LMH_FD_ECFH_community_0219.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\FSH\FD_SAMH_LEASE_NONMIL.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\LMH_FD_Silver Strand 1 LBP Disclosure.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MASD\MASD_lease.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\LMH_FD_CP_AL_lease.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\CPEN_Radon.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MAMFC\MA_LEJ_lease.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\CP_QU_radon.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\LMH_FD_CP_KS_asbestos.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\FSH\FD_SAMH_MOISTURE_PREVENTION.DOC")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MAMFC\MA_I_II_land.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\CP_29_radon.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\CP_QU_lease_07.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MAMFC\MA_I_II_pets.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MASD\MASD_LBP_Bethesda.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\LMH_FD_China Lake LBP Disclosure.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MAMFC\MA_I_II_asbestos_NDW_Flag.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MASD\MASD_Asbestos_bethesda.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\window_Staff_sgt.pdf")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\lmh_fd_cp_yuma_satellite.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\CP_YU_Lease_civilian.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\ECFH\LMH_FD_ECFH_pets_0219.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\SDFH\LMH_FD_SDFH_homebusiness_0219.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\CP_RD_Asbestos.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\CPEN_pets.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MASD\MASD_Construction.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\SDFH\SDFH_Noise_Fallon_May.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\CPEN_asbestos_SO.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\CPQH_prop65.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\LMH_FD_CP_YUMA_asbestos.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MAMFC\MA_LEJ_satellite.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MASD\MASD_pets.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\LMH_FD_CP_KS_construction.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MASD\MASD_asbestos_NY.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\LMH_FD_CPQH_Flood.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MAMFC\MA_I_II_noise_BH.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\LMH_FD_CP_YUMA_LEASE.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\JBLM\FD_JBLM_All_Mold_Mildew.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\lmh_Fd_Movein.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\CP_QU_satellite.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\JBLM\FD_JBLM_ALL_Lease.docx")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MAMFC\MA_I_II_LBP_portsmouth.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MAMFC\MA_I_II_noise_NAVSTA.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\CP_29_community.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\CP_CO_Propane_Safety.pdf")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\LMH_FD_SDFH_NEVADA_LEASE.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\SDFH\LMH_FD_SDFH_executivehome_leaseterm_0219.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\LMH_FD_SDFH_homebusiness.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MAMFC\MA_I_II_asbestos_SG.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MAMFC\MA_I_II_LBP_dahlgren.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\CPEN_land.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\LMH_FD_CP_KS_lease.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MASD\MASD_Lease_civilian.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\CP_29_land.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\CP_29_lbp_sm.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MAMFC\MA_I_II_LBP_NAVSTA.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\SDFH\SDFH_Noise_Fallon_NotMay.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\CPQH_Pets.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\JBLM\FD_JBLM_ALL_entering.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\FSH\FD_SAMH_CLEANING.DOC")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\SDFH\LMH_FD_SDFH_satelite_0219.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\ECFH\LMH_FD_ECFH_prop65_0219.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\SDFH\LMH_FD_SDFH_aa_0219.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\CP_QU_lease.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\ECFH\LMH_FD_ECFH satellite.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\NewDocs\CP_QH_community_new.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\LMH_FD_NBSD LBP Disclosure.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\SDFH\LMH_FD_SDFH_prop65_0219.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\CPEN_asbestos_Mesa.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\LMH_FD_CP_AL_construction.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\FSH\FD_SAMH_MOLD.DOC")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\CPEN_LBP_SO.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\FSH\FD_SAMH_LEAD_ASBESTOS.DOC")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MASD\MASD_hbb.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\ECFH\LMH_FD_ECFH_udeft_0219.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\LMH_FD_SDFH_prop650518.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\JBLM\FD_JBLM_Pet.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\CPEN_ordnance.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\LMH_FD_SDFH_CIVILIAN_LEASE.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\ECFH\LMH_FD_ECFH_noise_0219.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\CP_QU_Inventory.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\NewDocs\CP_QU_community_new.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\ECFH\LMH_FD_ECFH Pet Addenda.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\ECFH_II\LMH_FD_ECFH_II lbp.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\CP_29_lease.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\CP_QU_Ordnance.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MAMFC\MA_I_II_Historic.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\ECFH\LMH_FD_ECFH udeft0518.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MASD\MASD_asbestos_bellevue.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\LMH_FD_CP_KS_radon.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MAMFC\MA_I_II_LBP_paxriver.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\cp_al_radon.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\JBLM\FD_JBLM_Smoke_free.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\LMH_FD_SDFH_RECP.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MASD\MASD_LBP_NY.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\CP_29_Lease_civilian.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\KC\LMH_FD_CP_KS_pet.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\LMH_FD_CP_YUMA_ordinance.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\ECFH\LMH_FD_ECFH_satellite_0219.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\SDFH\LMH_FD_SDFH_community_0219.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MAMFC\MA_I_II_executive_lease.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\ECFH\LMH_FD_ECFH Civilian Lease.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\LMH_FD_CP_KS_lease_civilian.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\CP_29_ordnance.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\FSH\FD_SAMH_BLINDS.DOC")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MAMFC\MA_I_II_satellite.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\training\training_lease.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\CPEN_LBP_OH.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MASD\MASD_asbestos_thurmont.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\ECFH\LMH_FD_ECFH lbp.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MAMFC\MA_I_II_asbestos_oceana.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\lmh_fd_cp_al_radon.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\LMH_FD_NBVC Port Huenenme LBP Disclosure.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\LMH_FD_Seal Beach LBP Disclosure.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MAMFC\MA_I_II_asbestos_portsmouth.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MAMFC\MA_I_II_recp.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\FSH\FD_SAMH_MI_ALLOTMENT.DOC")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\JBLM\FD_JBLM_Fire_Safety_3.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\ECFH\LMH_FD_ECFH Lease.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\FSH\FD_SAMH_SURVEY.DOC")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MAMFC\MA_I_II_asbestos_Annapolis.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\JBLM\FD_JBLM_Fire_Safety_1.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MASD\MASD_LBP_Thurmont.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\LMH_FD_Chollas Heights LBP Disclosure.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\LMH_FD_MD_LEAD_2018.pdf")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MAMFC\MA_LEJ_construction.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\ECFH\LMH_FD_ECFH_land_0219.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\ECFH\ECFH_Noise.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\CP_CO_community.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MAMFC\MA_I_II_LBP_Oceana.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\SDFH\LMH_FD_SDFH_BedBug_0219.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\LMH_FD_CP_KS_recp.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\FSH\FD_SAMH_MI.DOC")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\LMH_FD_SDFH_satelite.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\LMH_FD_SDFH Noise Disclosure.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\ECFH\LMH_FD_ECFH_MI_0219.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\LMH_FD_Murphy Canyon LBP Disclosure.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\ECFH\LMH_FD_ECFH recp.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\FSH\FD_SAMH_WELCOME.DOC")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MAMFC\MA_I_II_community.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\ECFH\LMH_FD_ECFH Community Policies0518.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\FSH\FD_SAMH_MI2.DOC")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\CPQH_satellite.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\ECFH\LMH_FD_ECFH_BedBug_0219.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\SDFH\LMH_FD_SDFH_Flood_0219.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\CPEN_LBP_WM.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\CPEN_Lease.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\LMH_FD_CP_AL_recp.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\LMH_FD_CPQH_Mold.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\CP_VDS_asbestos.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\LMH_FD_CP_KS_pet.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\JBLM\FD_JBLM_LBP.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\LMH_FD_CP_YUMA_recp.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\LMH_FD_CP_AL_ordinance.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\FSH\FD_SAMH_PTE_EMAIL.DOC")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MASD\MASD_lbp_bh.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\ECFH\LMH_FD_ECFH_Lease_Ph2.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\JBLM\FD_JBLM_All_Garage.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MASD\MASD_community.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\FSH\FD_SAMH_LEASE.DOC")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MAMFC\MA_I_II_construction.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MAMFC\MA_I_II_hbb.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\ECFH\LMH_FD_ECFH_execleaseterm_0219.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MAMFC\MA_I_II_executive.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\JBLM\FD_JBLM_Asbestos.docx")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\ECFH\LMH_FD_ECFH_inventory_0219.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\SDFH\LMH_FD_SDFH_Lease_0219.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\ECFH\LMH_FD_ECFH Lease0518.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\JBLM\FD_JBLM_All_Emergency_Notification.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\LMH_FD_SDFH_Nevada_CIVILIAN_LEASE.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\SDFH\LMH_FD_SDFH_asbestos_0219.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\LMH_FD_CPQH_BEDBUGS.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\JBLM\FD_JBLM_radon.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MAMFC\MA_I_II_Lease_civilian.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\SDFH\LMH_FD_SDFH_movin_0219.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\ECFH\LMH_FD_ECFH_Flood_0219.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\FSH\FD_SAMH_SATELLITE.DOC")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\LMH_FD_Sub Base LBP Disclosure.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\FSH\FD_SAMH_MAINT_REQUEST.DOC")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MASD\MASD_historic.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\SDFH\LMH_FD_SDFH_inventory_0219.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\CPEN_asbestos_DM.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MAMFC\MA_I_II_LBP_yorktown.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\CP_QU_community.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\LMH_FD_SDFH_LBP_PAMPHLET_2018.pdf")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\CP_CO_radon.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\JBLM\FD_JBLM_All_basement_attic.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\ECFH\LMH_FD_ecfh_mold_0219.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\JBLM\FD_jblm_Construction and Relocation.docx")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\SDFH\LMH_FD_SDFH_Construction_0219.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\SDFH\LMH_FD_SDFH_pets_0219.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\LMH_FD_CP_AL_satellite.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\SDFH\LMH_FD_SDFH_ordinance_0219.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MAMFC\MA_I_II_LBP_LC.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\SDFH\LMH_FD_SDFH_recp_0219.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\NewDocs\CP_QU_lease_new.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MASD\MASD_asbestos_NA.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\ECFH\LMH_FD_ECFH_construction_0219.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MAMFC\MA_I_II_asbestos_dahlgren.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\JBLM\FD_JBLM_Fire_Safety_4.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MASD\MASD_executive.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\LMH_FD_Mold.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\FSH\FD_SAMH_PETS.DOC")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\LMH_FD_CP_YUMA_pet.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\LMH_FD_NBVC Point Mugu LBP Disclosure.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MAMFC\MA_I_II_Lease_civilian")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MASD\MASD_asbestos_arlington.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\JBLM\FD_JBLM_Fire_Safety_5.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MAMFC\MA_I_II_asbestos_NAVSTA.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MAMFC\MA_I_II_Community_exec.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\FSH\FD_SAMH_RELEASE.DOC")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\LMH_FD_CP_KS_lbp.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MAMFC\MA_I_II_LBP_indianhead.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MAMFC\MA_I_II_noise_fc.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\LMH_FD_CP_AL_community.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\ECFH\LMH_FD_ECFH HBB.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MAMFC\MA_LEJ_community.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MASD\MASD_asbestos_BH.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\CP_QU_asbestos.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\LMH_FD_CP_AL_pet.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\ECFH\LMH_FD_ECFH Asbestos.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MASD\MASD_asbestos_NO.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\CP_29_asbestos.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MAMFC\MA_I_II_asbestos_LC.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MAMFC\MA_LEJ_pets.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\ECFH\LMH_FD_ECFH_hbb_0219.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\LMH_FD_CP_KS_satellite.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\lmh_fd_cp_yuma_lbp.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\LMH_FD_Chesterton LBP Disclosure.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MAMFC\MA_I_II_noise_WS_over75.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MAMFC\MA_I_II_LBP_DC.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MASD\MASD_LBP_potomac.doc")),
new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\SDFH\LMH_FD_SDFH_udeft_0219.doc")),
            };

            ZipDirs dirList = new ZipDirs(dirArray);
            foreach (ZipDir path in dirList)

            {
                string source = path.FullPath;
                string DestinationPath = Path.Combine(@"G:\Shared drives\LMH-IT\LMH Yardi Documents\Documents With Text Lincoln\", path.FileName);

                try
                {
                    using (StreamReader sr = new StreamReader(source))
                    {
                        string contents = sr.ReadToEnd();
                        if (!contents.Contains("Lincoln"))
                        {
                            Console.WriteLine("File does not have text Lincoln: " + DestinationPath);
                            //File.Copy(source, DestinationPath);
                        }
                        else
                        {
                            Console.WriteLine("File needs to be updated: " + DestinationPath);
                            File.Copy(source, DestinationPath);
                        }
                    }
                }
                catch
                {
                }
            }
        }
    }

    // Path.GetDirectoryName(path.FullPath)
    public class ZipDir
    {
        public string FileName { get; set; }
        public string FullPath { get; set; }
        public string FolderName { get; set; }
        public string FileNameNoExt { get; set; }

        public ZipDir()
        {
        }
        public ZipDir(DirectoryInfo path)
        {
            this.FileName = path.Name;
            this.FullPath = path.ToString();
            this.FolderName = Path.GetFileName(Path.GetDirectoryName(path.ToString()));
            this.FileNameNoExt = System.IO.Path.GetFileNameWithoutExtension(path.ToString());
        }
    }

    // Collection of Person objects. This class
    // implements IEnumerable so that it can be used
    // with ForEach syntax.
    public class ZipDirs : IEnumerable
    {
        private ZipDir[] _zipdir;
        public ZipDirs(ZipDir[] pArray)
        {
            _zipdir = new ZipDir[pArray.Length];

            for (int i = 0; i < pArray.Length; i++)
            {
                _zipdir[i] = pArray[i];
            }
        }

        // Implementation for the GetEnumerator method.
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public DirEnum GetEnumerator()
        {
            return new DirEnum(_zipdir);
        }
    }

    // When you implement IEnumerable, you must also implement IEnumerator.
    public class DirEnum : IEnumerator
    {
        public ZipDir[] _zipdirs;

        // Enumerators are positioned before the first element
        // until the first MoveNext() call.
        private int position = -1;

        public DirEnum(ZipDir[] list)
        {
            _zipdirs = list;
        }

        public bool MoveNext()
        {
            position++;
            return (position < _zipdirs.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public ZipDir Current
        {
            get
            {
                try
                {
                    return _zipdirs[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}
