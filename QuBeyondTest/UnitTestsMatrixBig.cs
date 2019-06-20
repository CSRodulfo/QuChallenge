using NUnit.Framework;
using QuBeyond.Backend.Bussiness.Matrixes;
using QuBeyond.Backend.Services;
using System.Collections.Generic;
using System.Linq;

namespace QuBeyondTest
{
    public class UnitTestsMatrixBig
    {
        private IEnumerable<string> matrix;

        [SetUp]
        public void Setup()
        {
            matrix = new string[] {
                "XEHKOWBYWEJFHCHZWADETUWRXXKRYABDWAXZIAQQDCPDBOSTON",
                "EONGCADBFHJJJYPDBYGEGBMUXXONAVCWJNFBTVTGCHEJSSWEKS",
                "IPEAJECONCORDGGIIEJICDNSEBHHHDWQYZMXLOOHDANRELYYXI",
                "PTAQJXYNNBXACURAIHDCIESMSVPUAYCDARXUHDUWDRKZKICEOJ",
                "XHXVDYVYWEWHTAWQYEHKCSXVWWHBJEHDUDIGENFGILPNNHBQQH",
                "EEUAVRBTFIJCTTAWCFVGUMDDXILENTSDSUOVGQKQCEPLNNVWLB",
                "LNSANNAPOLISFEAYYCEPDOHJSLRUXSLITTLEROCKTSUTOFRDXZ",
                "JCPUGVAIWJRYWXLKFRALEIGHIZBECAFEIVJPPDVAMTNKJMJDYO",
                "MYIDXZJPTUSMDZBUGHELENAMSACGHGUWNAWZRQQIOOQVKKAXPL",
                "CAYAZHGQBCCSZSAMLQPKFEKGMERWYIKWZGUGVQGFTNBDSPBQRH",
                "ICSYXYRXAFEJZANTVERJPSUJCSYQHDOCGLQTOPEKAXUQDKRPIB",
                "YIKGKBYGHXBAPLYMTSLTOIUHOLWZMSSALEMOPRMEEJYCRXEFCM",
                "BOFIKQLHQPKCRTUKETYNNPOKLPQJMJFATNNAPOHEHFMLHNPBHO",
                "LWLJUNEAUIVKULPQSMYPBWDNUORYQHADKAJDMVIRRWAXRNONMJ",
                "MDLUPISRNPISIAMFBCTUIRBXMDGGHONOLULUJIIFWZUBGMYPOL",
                "MFGYRJPRJUSOFKKCMQNOSMSVBOQBBWXQOYUTPDPLNZLYDGHQNL",
                "PZZGMBHIGLMNVETZGWTQMTQAIMGHQROTVEUABEDRBEEAWHCVDD",
                "NCJUNOOSSBFQKCRTACSYALWRAPNXSKCQTTJJTNDQWIVWOOZKSR",
                "VHUQIDEBPDRNDIEWRICJRWMROUHNCCSFLZHKHCZECGUJMSGZDQ",
                "SEQWVCNUKOKHQTNMYMLHCMHAZAGHTIWKWEDYXERZUMMCPQHZBN",
                "DYILJKIRRKSKXYTXXTLFKOTNASMRLKMRFMONTGOMERYOTSNOPH",
                "HETSFEXGMLBHIAONOOSAQNLIQTVHWFDHBOUOVQTUFJPFDMEOBW",
                "MNTERALWFAPDTNNUDXVBATONROUGEGBAEBWKHYDEQPPGZNQNFO",
                "JNYHJYAFXHUESODVHQAHSPNNDAYYKPJRYNLYYTTQQXFRDDSVVG",
                "REEEPLINCOLNBVOVJQKUREOYEQOTDUJTDXTLLZSJUYGXJLFBTT",
                "QICLXMVROMDFVKYXKHWOILJJPGXPJFPFGKIVDBGQXRDHKYBWOY",
                "SERGQVWSCAALTJEKZZUHHILAZVUOTVQOMLXWZFFIZUMMHGRCLH",
                "ZUJLLYEPCCSLYMYTZZUKPEURRZFHQZHROAPQJBOADKJMVZMSFB",
                "AREZVOPRJIZZUWQXZKKLSRKRUIVRTSLDRNZMOTHHDMJHFRTQDZ",
                "ALFMFNIIYTJWBIDAPATDUCELWXBNCNCSFSLGNCBLVNMWCBNFNX",
                "SIFQJTINXYXGZQCMTVPNWSGOETPLDOTPNIPIZMDXAFSQTWNRIR",
                "AZEDXWCGXRTPSJGYXANLXCNTNASFREPGKNSUJTBKTWHTQGLGDN",
                "DHRWVQSFVZHSABMDOOSFPPNPEZAGCKLKWGLHENYPPJDWIFJPPC",
                "USSKOREIHUNZCVXKJRDKAPNEJXNNPGBNUFEDJCFIJLSISKRHYX",
                "OGODDBAEQOCMRBVNVAXSGXFANDTPEHVAYUQIJHXENZNRAZRXSY",
                "UFNEZAJLWQFQAPILXEKJJQISNNAWPBXPZZMQFVRRXNYIHQTRCD",
                "SICLXVHDIXRZMQCDJYPHJQWHJVFDZNYLLYYZNHVRUFZQIXAQSR",
                "XMIXNRLODPATEARDFIYTAMGRBTEOEQWWJNUKPRGEYTLLKALNXV",
                "GLTGIJQVCNNSNPVFIDUSLVUBOURBLVDBJRDNSGIVNXHRCCLYSN",
                "XTYXFMUEKGKVTWUIPCJCHVVVTZTMDEDBMIPWORKBAUGUSTAZKK",
                "NCUPETZRFVFWOZKOKOMZNFMADISONOUDESMKYZMLXRNDPDHYCC",
                "HOPCMZDWTUOUQLYLOLYMPIAEWUWINDIANAPOLISIQIIPCXAWGZ",
                "XLROVXHNXHRMQILMWUYFTQOMIDENVERJMSNASHVILLEBYSSBPW",
                "GTUTKPNAZATLANTAHMUFEQORSCIODORDTYYCARSONCITYUSYYY",
                "VWIREWSIKPXJZECUNBLZAUJGTDYNINWBWFWVBIUWWFXWZGEEUC",
                "KZKBUNORBRWHHECXZUSPQITCSVLGZLFRYSUZBKGYFANVREEDAM",
                "HRJTHNJIOXDLLTKZFSIEGLGZSYXOHQSUQVGWDKKCVHDRVEGTZV",
                "WRNXBOXBIUOXQMJZLLGKEMBYRIXGLQVHLXEPGHNFVUVUPWZSXS",
                "HFVPKDRBSGKRRVLUXPWPUMRCQZYPIVPXMYNEXLXOMVJNXWATAH",
                "SGRCYNSHEHJIAWTPVYPFGDLLLSVSAINTPAULEBDDCHGDTPRBOP",
            };
        }

        [Test]
        public void FindWord_Take()
        {
            Matrix myMatrix = new Matrix(matrix);

            var finderWord = myMatrix.FindWords(new string[] {
                "ALBANY",
                "ANNAPOLIS",
                "ATLANTA",
                "AUGUSTA",
                "AUSTIN",
                "BATONROUGE",
                "BISMARCK",
                "BOISE",
                "BOSTON",
                "CARSONCITY",
                "CHARLESTON",
                "CHEYENNE",
                "COLUMBIA",
                "COLUMBUS",
                "CONCORD",
                "DENVER",
                "DESMOINES",
                "DOVER",
                "FRANKFORT",
                "HARRISBURG",
                "HARTFORD",
                "HELENA",
                "HONOLULU",
                "INDIANAPOLIS",
                "JACKSON",
                "JEFFERSONCITY",
                "JUNEAU",
                "LANSING",
                "LINCOLN",
                "LITTLEROCK",
                "MADISON",
                "MONTGOMERY",
                "MONTPELIER",
                "NASHVILLE",
                "OKLAHOMACITY",
                "OLYMPIA",
                "PHOENIX",
                "PIERRE",
                "PROVIDENCE",
                "RALEIGH",
                "RICHMOND",
                "SACRAMENTO",
                "SAINTPAUL",
                "SALEM",
                "SALTLAKECITY",
                "SANTAFE",
                "SPRINGFIELD",
                "TALLAHASSEE",
                "TOPEKA",
                "TRENTON",
             });

            Assert.AreEqual(10, finderWord.Count());
        }

        [Test]
        public void FindWord_ContainsFirstWord()
        {
            Matrix myMatrix = new Matrix(matrix);

            var finderWord = myMatrix.FindWords(new string[] {
                "ALBANYs",
                "ANNAPOLIS",
                "ATLANTA",
                "AUGUSTA",
                "AUSTIN",
                "BATONROUGE",
                "BISMARCK",
                "BOISE",
                "BOSTON",
                "CARSONCITY",
                "CHARLESTON",
                "CHEYENNE",
             });

            Assert.AreEqual("ANNAPOLIS", finderWord.ToList().FirstOrDefault());
        }
    }
}