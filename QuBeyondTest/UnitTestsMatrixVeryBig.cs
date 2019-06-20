using NUnit.Framework;
using QuBeyond.Backend.Bussiness.Matrixes;
using QuBeyond.Backend.Services;
using System.Collections.Generic;
using System.Linq;

namespace QuBeyondTest
{
    public class UnitTestsMatrixVeryBig
    {
        private IEnumerable<string> matrix;

        [SetUp]
        public void Setup()
        {
            matrix = new string[] {
                "RAGATQGEORGIASMWDSBNMXXAYUKXDQAMPETKHVDFJEVHAJFHHJ",
                "JVEGMRKPLSABYFGTFCJXVZVFRFMLZSRNILHUXMVGBTHHHZNIMA",
                "XMHCGLVFFPSMINNESOTAENEWYORKDCQWIEPWMBUUHIBXKVEDLS",
                "PLJOCVIPDMZNRHJNYBTIJKJRRRZEADJVXHNYWIVRYIAQNLVVRO",
                "WVYUXUEWNFULNVTNNERKSTGANZDLXDFLLLOLSOUTHDAKOTAZKP",
                "XLQVXJGSKOBKMKYEKOHBBJUPLALASKAVGLRHTRULUDCKIGDUSY",
                "XCQSFUBTGJCNUUFSGPWRDPMDORARKANSASTKVKEBSDNCWGAZSO",
                "SRVYLHQSPTIXSJCSELWWNGIRERKWDMUZIAHFIMKUBGKJQNZGAL",
                "GLBUIIAINDIANAVEXBZSEFSHJVWHCESWKBCWNTKSBHOOLZRALE",
                "VGSCOLORADOFJSPEXLPRBHSIZUPTHKOPUTAHBYOAREWCAVRPIP",
                "EFBJWLZAEDNXSFAZTTIHRSICQLETKVUXXEROIOXEMUKNTYUBZZ",
                "QXVWARLNEWJERSEYHGSBAQSMRQOHUGTDETOMNTHCNPFMJKUPOA",
                "GIRHIYOOCYHKCSQYNICRSRSTTROIPJHSUCLVSBMOOSELNDQIMH",
                "NEMEXFJYTNYBNIMFNDRCKMICHIGANHCJBFIHMRJNRZFUHELLLR",
                "GAZAFEDPWYRNAGJEELXYAAPLEACWSQAIDJNKAJONTYEIXNYLME",
                "XUOUGCDATJRKHPYULWTDQBPUAJWNLHRKXWATSMZEHSVBSPTGOX",
                "AMMYGTTCHKZQNWVCMHMCDMIJERATGEOJGKYISZZCDJKFCVVKNR",
                "IZTFPEPEBAZJCEUAIRMARYLANDLJIZLQAMSVAQSTARCSVGPZTL",
                "UUZLZXHENSKNFYYMSXTWFJVFLVATXTITDXUFCEJIKWIAMCCHAJ",
                "SBVCIAZWOEPAGZXKSGHJMQJWFSBOKENTUCKYHGICODVSRYRHNQ",
                "XPCWESIDALASKAVAODBKDDELAWAREOAJKGPZUNBUTGVLHNMEAZ",
                "CPEENREIAVZDFOTDUIDAHOGKKSMNWURUJBFDSKZTAPZLZGDSMC",
                "FVKGEEMSDPKDQVOURTPXCVCXCDAWXDHXBAWCENKGGRZAJELOGF",
                "NWPTJZWEMVEPADYEIWZIYBDKBGDFWGOPLTCTTUJIFIXZMMOBXW",
                "ANWSWQUFZWAEMJZCKNJHYYZWZCCUEDDYTBJZTYRSLIQOXNXHZG",
                "QAGSIUKFZRRRDLCYQDMKPIVKOZFOPWEDOTNISXORVUVERMONTY",
                "ZKPBXFSWCGIZHTWAKPOHIONHDMYFMBIVYHTSTZMAKHIUMUSOXV",
                "UVANUZSFCJZFSBESZVVZWCOHJIXPKYSPXRUMLNXZBDLZZYSXIQ",
                "UCWFXBCLDKOODRSOKEYNALPZAENRZZLMQGKVCEYROOLIOTFUXK",
                "ULYJKKEOMBNOOXTVPYOESBUWSJLOKLAHOMAPDEXXJNIJJQIFKH",
                "HBEIXAZRJHACRLVOPWFWHDAERGESLDNYEZESPPXWOFNJZGRRAA",
                "IVBAINSIJAATSIIJZNZMIDIAFUCIBZDQJIYSEJNTHSOWDUENBW",
                "ZPOSHSMDCHOZXLRXPKPENNSYLVANIAFNFYRJPXLJIUIFRSJFBX",
                "YOKPFAHAWAIILPGTGHDXGRPGRQWRDMAINEHHHNHLKWSGIDJBPP",
                "QDFDPSOYDEVIRGINIASITZWIXWNPACJVDGLTEIMDHALASKAFRV",
                "REVRJUQHWFTKRSNEGGOCOTBHBRIDIAKHQVJKKKREDXAFTYKRKZ",
                "HDLCSNEWHAMPSHIREBNONPFJNBWVNHJYWDRLPWFBGDBBLVEOOP",
                "HBIBKJBDJCGKGYAKXUWSDTCPNLPMDKDAQMTVFQTUXFTOOREGON",
                "CFLJNFKVIQYYPQXPVOYNLFJIGYGCCPAGMSAIADEVBOOIUFWFUD",
                "GGOOSDAYQXMBJMMJMPOZMTLDBNWAAMOGAGUBPXKDFYSOIIUVTU",
                "KGUBGGWPJZJGCMVTNSJFMXWNDEFLUODRMRGBEIAISTYWSCBETF",
                "ZFQDTGLBJEXVLXGTDQGBXDWWWPNIIOOWXKAWIHFUGWYKIICFLD",
                "WISCONSINVGWHYBEMGRHOUFRZMOFLYMBWKCNBAXKDGBUAAJFLF",
                "HENLXNRILSAVRUBBGIARPPQBNBAOHIUIOPHXYIHSYNDFNALVZB",
                "AOSHBVYZSOOONNBGTDUIQFVGCPDRRIUHFWAMTSSFZPFAALNRUH",
                "FSONCTITDJGNUWZSURQVNCLZYIENQMKKNEZEDFRCAUQAFAWGFC",
                "QHTZLPNUMXRWTZCFOPPMSWUGQHDILNOTUNOYVCOHGKVOVIXNXB",
                "PHQPXUSGCCHHYZFCXTUZNHBJIBLACKPOXMFZJFUDTIVZOHQZNZ",
                "SLAMKQKKOARYLWTQWGOKRQBOXWYOMINGZJRGHDRBTORZEKPPNC",
                "TNCUTVVAPVMAELAPPJZMQMVLOZMBODRKUCXZSWXADLVXHDCQCJ",
            };
        }

        [Test]
        public void FindWord_Take()
        {
            Matrix myMatrix = new Matrix(matrix);

            var finderWord = myMatrix.FindWords(new string[] {
                "ALASKA",
                "BLACK",
                "PEPE",
                "ALABAMA",
                "ARIZONA",
                "ARKANSAS",
                "CALIFORNIA",
                "COLORADO",
                "CONNECTICUT",
                "DELAWARE",
                "FLORIDA",
                "GEORGIA",
                "HAWAII",
                "IDAHO",
                "ILLINOIS",
                "INDIANA",
                "IOWA",
                "KANSAS",
                "KENTUCKY",
                "LOUISIANA",
                "MAINE",
                "MARYLAND",
                "MASSACHUSETTS",
                "MICHIGAN",
                "MINNESOTA",
                "MISSISSIPPI",
                "MISSOURI",
                "MONTANA",
                "NEBRASKA",
                "NEVADA",
                "NEWHAMPSHIRE",
                "NEWJERSEY",
                "NEWMEXICO",
                "NEWYORK",
                "NORTHCAROLINA",
                "NORTHDAKOTA",
                "OHIO",
                "OKLAHOMA",
                "OREGON",
                "PENNSYLVANIA",
                "RHODEISLAND",
                "SOUTHCAROLINA",
                "SOUTHDAKOTA",
                "TENNESSEE",
                "TEXAS",
                "UTAH",
                "VERMONT",
                "VIRGINIA",
             });

            //Assert.Contains("ALASKA", finderWord.ToList());

            Assert.AreEqual(10, finderWord.Count());
        }

        [Test]
        public void FindWord_ContainsFirstWord()
        {
            Matrix myMatrix = new Matrix(matrix);

            var finderWord = myMatrix.FindWords(new string[] {
                "ALASKA",
                "BLACK",
                "PEPE",
                "ALABAMA",
                "ARIZONA",
             });

            Assert.AreEqual("ALASKA", finderWord.ToList().FirstOrDefault());
        }
    }
}