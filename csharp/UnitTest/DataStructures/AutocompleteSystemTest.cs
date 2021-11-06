namespace UnitTest.DataStructures
{
    using FluentAssertions;
    using LeetCode.DataStructures;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class AutocompleteSystemTest
    {
        [TestMethod]
        public void Test1()
        {
            var strings = new string[] { "i love you", "island", "iroman", "i love leetcode" };
            var times = new int[] { 5, 3, 2, 2 };
            var ac = new AutocompleteSystem(strings, times);
            ac.Input('i').Should().Equal("i love you", "island", "i love leetcode");
            ac.Input(' ').Should().Equal("i love you", "i love leetcode");
            ac.Input('a').Should().Equal();
            ac.Input('#').Should().Equal();
            ac.Input('i').Should().Equal("i love you", "island", "i love leetcode");
            ac.Input(' ').Should().Equal("i love you", "i love leetcode", "i a");
            ac.Input('a').Should().Equal("i a");
            ac.Input('#').Should().Equal();
            ac.Input('i').Should().Equal("i love you", "island", "i a");
            ac.Input(' ').Should().Equal("i love you", "i a", "i love leetcode");
            ac.Input('a').Should().Equal("i a");
            ac.Input('#').Should().Equal();
        }

        [TestMethod]
        public void Test2()
        {
            var strings = new string[] { "uqpewwnxyqxxlhiptuzevjxbwedbaozz", "ewftoujyxdgjtazppyztom", "pvyqceqrdrxottnukgbdfcr", "qtdkgdbcyozhllfycfjhdsdnuhycqcofaojknuqqnozltrjcabyxrdqwrxvqrztkcxpenbbtnnnkfhmebj", "jwfbusbwahyugiaiazysqbxkwgcawpniptbtmhqyrlxdwxxwhtumglihrgizrczv", "cfptjitfzdcrhw", "aitqgitjgrcbacgnaasvbouqsqcwbyskkpsnigtfeecmlkcjbgduban", "utsqkmiqqgglufourfdpgdmrkbippffacwvtkpflzrvdlkdxykfpkoqcb", "ethtbdopotpamvrwuomlpahtveyw", "jiaqkaxovsqtkpdjfbkajpvpyetuoqwnrnpjdhoojbsdvneecsdvgqpyurmsvcy", "j", "btbnuplyeuccjbernsfbnveillrwdbqledwvpmvdbcugkurrkabtpykhlcogeszclyfuquafouv", "hndjzblegevtfkgbjttektox", "gtvnlninpvenapyfgmsjdisfnmiktitrutctawosjflvzfkbegnprixzqwzcyhoovsivuwmofsveqkyosowuyamuvy", "sawrirvrfrbfagreahrioaombukmdwztbpggnxd", "mgdcwptvbvhzyvvumvbjjn", "otjvvkegwleyyxtghwgfmlsqlhrlibdvqfinyyebotjpwoaejhtornfgikmifdmwswbqgwhcbzuhrpajxuqicegcptszct", "zlondsttyvnnnnxjtoqnlktitwzurissczzbyfsbgpoawodwjpsmavaugnhqtsbeixwl", "yehvdehbtmwqkmcjmvpivfzqvevkotwzvjoyfvp", "bjximtpayjdcxbrnksbtfnpynzaygygdflowewprqngdadzdhxcpgapjejojrkzrutgcsfpfvpluagniqimfqddldxqiw", "bysyrxfykivyauysytgxfhqcrxliulahuizjvozpywrokxujhzpauxwufcxiitukljiiclatfrspqcljjoxpxziumstnhqr", "uxtvutlgqapyfltiulwrplesmtowzoyhhjhzihatpuvmutxqgxfawpwypedbz", "jzgsdjdawrqfladolduldhpdpagmvllvzamypuqlrpbmhxxadqaqrqavtxeghcyysjynovkiyjtvdluttodtmtocajgttmv", "mbijfkmepalhdiubposdksdmmttxblkodcdrxbnxaqebnwliatnxpwaohbwkidia", "ljggggbyxwrwanhjonoramexdmgjigrtpz", "cqfvkutpipxjepfgsufonvjtotwfxyn", "kvseesjazssavispavchdpzvdhibptowhyrrshyntpwkez", "nveuzbaosuayteiozmnelxlwkrrrjlwvhejxhupvchfwmvnqukphgoacnazuoimcliubvhv", "uwrpwhfdrxfnarxqpkhrylkwiuhzubjfk", "bniyggdcloefwy", "ihranmhbsahqjxesbtmdkjfsupzdzjvdfovgbtwhqfjdddwhdvrnlyscvqlnqpzegnvvzyymrajvso", "lscreasfuxpdxsiinymuzybjexkpfjiplevqcjxlm", "uwgnfozopsygnmptdtmmuumahoungpkodwxrcvfymqpeymaqruayvqqgoddgbnhemtsjifhxwiehncswxzrghf", "nyfbxgcpfrzyqwfjzgmhuohjhrjizsyjqgmertmooeiaadcmiuyyylpcosnweoyydeauazhzbeaqn", "tpylrxbwnkrfxckfdlvrbytaezuzmyscpvruthuvbxjenkeolvqsrjqzizyclzmqtjvnamdansmzyspcfghfprorqprua", "nhldlmxpuckxeekipkrzugatjiivtazjbjyxokksyueyjbgmrovbckbxqcqefaiavzsarbbypgmpxe", "sylraqsd", "xr", "xkzpxkhrucyatpatkigvntohihibyisyqtkjdhatdvyvxbjttz", "nvnz", "blzddwxphkgqfsfzfclwytstpvpzgcdeggdwzukzirscfzcteeuqbmmrfxcnokbbyxkqrxtjfarcefiynwfmy", "inuxmuhtdwpuvyludwtokhtalxbuccepsayrjycbcwbtnfholjvkmypodv", "awwillrm", "xznodxngrstjrwqzmlmigpw", "khlxjdtictufdfbkgfusdtaaeuspbbfmtjodflgqofzlqnulkdztflm", "nlngmckslyqzjiyiexbropbxnynjcstziluewypboqhqndqsxhtnosrgrameajovsclrgwqjgnztvxrkhwnxkfrf", "yroadxhxyacaexrwju", "ujxlbpcbxdqrvubifnpzjmmkolyljzjhdegaiowaal", "tnfnjgtxbckbpyplucprxcqzhrfjimylmlhdglntfydepltjvklyxesndzuubienhvuaqc", "ouedhtkpkg", "ygchsrrubucqffewifsxaefwocfaiiupqbomktvrcddggqfgnaycstpccwtbheyaqwhosxajqeqqxzyjsfng", "jqqgpjvfkgjh", "csowoazaiyejgyixszqmtctpzlkccccqregyhtvxccvrpkupwcyhqatxscevzdfbdqnuyadiyfnhysddfyxpgqtjiogmxsmzbbkr", "dlzxdpchkdaztkqtrjmuujgoiae", "plcjkwukkyqluxjbhxsyeaqvviinfuujsafwsquidvmutsrukxwrv", "yopqbtpoqhpcktjangauzcvvpephhprpaaclbbkgchlqkrwdsaupeizlwxzcpkchoagmrrkwdkthosmrjefgbumnrjsb" };
            var times = new int[] { 12, 9, 4, 4, 1, 5, 3, 4, 7, 9, 2, 4, 2, 3, 11, 13, 1, 3, 4, 10, 7, 1, 9, 5, 10, 14, 5, 3, 2, 11, 5, 14, 4, 13, 11, 5, 15, 8, 1, 12, 2, 11, 4, 2, 11, 14, 9, 12, 1, 7, 13, 11, 7, 2, 6, 10 };
            var ac = new AutocompleteSystem(strings, times);
            ac.Input('w').Should().Equal();
            ac.Input('o').Should().Equal();
            ac.Input('f').Should().Equal();
        }
    }
}
