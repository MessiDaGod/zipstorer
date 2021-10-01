using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace Test
{
    [TestClass]
    public class UnitTestFolder
    {
        public string NewFileName { get; set; }

        [ClassInitialize]
        public static void Initialize(TestContext test)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        }

        public void YardiFolderDownload()
        {
            ZipDir[] dirArray = new ZipDir[12]
            {
                new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\JBLM\FD_JBLM_ALL_Lease.docx")),
                new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\KC\LMH_FD_CP_KS_pet.doc")),
                new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\lmh_fd_risk.doc")),
                new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\CP_CO_Propane_Safety.pdf")),
                new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\training\training_lease.doc")),
                new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\ECFH_II\LMH_FD_ECFH_II lbp.doc")),
                new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\CPQH\NewDocs\CP_QU_lease_new.doc")),
                new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\FSH\FD_SAMH_BLINDS.DOC")),
                new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MAMFC\MA_I_II_Lease_civilian.doc")),
                new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\SDFH\LMH_FD_SDFH_Construction_0219.doc")),
                new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\ECFH\LMH_FD_ECFH_BedBug_0219.doc")),
                new ZipDir(new DirectoryInfo(@"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MASD\MASD_Construction.doc")),
            };

            ZipDirs dirList = new ZipDirs(dirArray);
            foreach (ZipDir path in dirList)
            {
                NewFileName = path.FileName + ".zip";
                using (ZipStorer zip = null /*ZipStorer.Create(NewFileName)*/)
                {
                    var pos = path.FullPath.LastIndexOf(Path.DirectorySeparatorChar);
                    Console.WriteLine("Path: " + path.FullPath);
                    Console.WriteLine("FileName: " + path.FileName + ".zip");
                    Console.WriteLine("Full path and FileName: " + path.FullPath + path.FileName + ".zip");

                    //zip.AddDirectory(ZipStorer.Compression.Deflate, path.FullPath, null);
                }
            }
        }

        // [TestMethod]
        public void Folder_Test()
        {
            string path = @"\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\FD_DOCS\MASD\";
            var sampleFile = new DirectoryInfo(path).Name;
            sampleFile += ".zip";

            using (ZipStorer zip = ZipStorer.Create(sampleFile))
            {
                Console.WriteLine(path);
                //zip.AddDirectory(ZipStorer.Compression.Deflate, path, null);
            }
        }
    }

    public class ZipDir
    {
        public string FileName { get; set; }
        public string FullPath { get; set; }

        public ZipDir(DirectoryInfo path)
        {
            this.FileName = path.Name;
            this.FullPath = path.ToString();
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
