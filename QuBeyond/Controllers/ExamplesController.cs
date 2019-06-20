using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuBeyond.Model;

namespace QuBeyond.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamplesController : ControllerBase
    {
        [HttpGet("MatrixQu")]
        public ActionResult<QuMatrixModel> GetExampleMatrixQu()
        {

            return new QuMatrixModel()
            {
                matrix =
                    new string[] {
                    "abcdc",
                    "fgwio",
                    "chill",
                    "pqnsd",
                    "uvdxy",
                  },
                words =
                    new string[] {

                   "chill",
                   "cold",
                    }
            };
        }

        [HttpGet("MatrixVeryBig")]
        public ActionResult<QuMatrixModel> GetExampleMatrixVeryBig()
        {

            return new QuMatrixModel()
            {
                matrix =
                    new string[] {
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
            },
                words =
                    new string[] {
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
               }
            };
        }
    }
}