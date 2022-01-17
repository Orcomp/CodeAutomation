﻿namespace %PROJECTNAMESPACE%
{
    using System;
    using System.Globalization;

    /// <summary>
    /// Class FontAwesome, characters can be found at http://fortawesome.github.io/Font-Awesome/cheatsheet/
    /// </summary>
    public static class FontAwesome
    {
        public static readonly string Adjust = GetCharacter("&#xf042");
		public static readonly string Adn = GetCharacter("&#xf170");
		public static readonly string AlignCenter = GetCharacter("&#xf037");
		public static readonly string AlignJustify = GetCharacter("&#xf039");
		public static readonly string AlignLeft = GetCharacter("&#xf036");
		public static readonly string AlignRight = GetCharacter("&#xf038");
		public static readonly string Ambulance = GetCharacter("&#xf0f9");
		public static readonly string Anchor = GetCharacter("&#xf13d");
		public static readonly string Android = GetCharacter("&#xf17b");
		public static readonly string Angellist = GetCharacter("&#xf209");
		public static readonly string AngleDoubleDown = GetCharacter("&#xf103");
		public static readonly string AngleDoubleLeft = GetCharacter("&#xf100");
		public static readonly string AngleDoubleRight = GetCharacter("&#xf101");
		public static readonly string AngleDoubleUp = GetCharacter("&#xf102");
		public static readonly string AngleDown = GetCharacter("&#xf107");
		public static readonly string AngleLeft = GetCharacter("&#xf104");
		public static readonly string AngleRight = GetCharacter("&#xf105");
		public static readonly string AngleUp = GetCharacter("&#xf106");
		public static readonly string Apple = GetCharacter("&#xf179");
		public static readonly string Archive = GetCharacter("&#xf187");
		public static readonly string AreaChart = GetCharacter("&#xf1fe");
		public static readonly string ArrowCircleDown = GetCharacter("&#xf0ab");
		public static readonly string ArrowCircleLeft = GetCharacter("&#xf0a8");
		public static readonly string ArrowCircleODown = GetCharacter("&#xf01a");
		public static readonly string ArrowCircleOLeft = GetCharacter("&#xf190");
		public static readonly string ArrowCircleORight = GetCharacter("&#xf18e");
		public static readonly string ArrowCircleOUp = GetCharacter("&#xf01b");
		public static readonly string ArrowCircleRight = GetCharacter("&#xf0a9");
		public static readonly string ArrowCircleUp = GetCharacter("&#xf0aa");
		public static readonly string ArrowDown = GetCharacter("&#xf063");
		public static readonly string ArrowLeft = GetCharacter("&#xf060");
		public static readonly string ArrowRight = GetCharacter("&#xf061");
		public static readonly string ArrowUp = GetCharacter("&#xf062");
		public static readonly string Arrows = GetCharacter("&#xf047");
		public static readonly string ArrowsAlt = GetCharacter("&#xf0b2");
		public static readonly string ArrowsH = GetCharacter("&#xf07e");
		public static readonly string ArrowsV = GetCharacter("&#xf07d");
		public static readonly string Asterisk = GetCharacter("&#xf069");
		public static readonly string At = GetCharacter("&#xf1fa");
		public static readonly string Automobile = GetCharacter("&#xf1b9");
		public static readonly string Backward = GetCharacter("&#xf04a");
		public static readonly string Ban = GetCharacter("&#xf05e");
		public static readonly string Bank = GetCharacter("&#xf19c");
		public static readonly string BarChart = GetCharacter("&#xf080");
		public static readonly string BarChartO = GetCharacter("&#xf080");
		public static readonly string Barcode = GetCharacter("&#xf02a");
		public static readonly string Bars = GetCharacter("&#xf0c9");
		public static readonly string Beer = GetCharacter("&#xf0fc");
		public static readonly string Behance = GetCharacter("&#xf1b4");
		public static readonly string BehanceSquare = GetCharacter("&#xf1b5");
		public static readonly string Bell = GetCharacter("&#xf0f3");
		public static readonly string BellO = GetCharacter("&#xf0a2");
		public static readonly string BellSlash = GetCharacter("&#xf1f6");
		public static readonly string BellSlashO = GetCharacter("&#xf1f7");
		public static readonly string Bicycle = GetCharacter("&#xf206");
		public static readonly string Binoculars = GetCharacter("&#xf1e5");
		public static readonly string BirthdayCake = GetCharacter("&#xf1fd");
		public static readonly string Bitbucket = GetCharacter("&#xf171");
		public static readonly string BitbucketSquare = GetCharacter("&#xf172");
		public static readonly string Bitcoin = GetCharacter("&#xf15a");
		public static readonly string Bold = GetCharacter("&#xf032");
		public static readonly string Bolt = GetCharacter("&#xf0e7");
		public static readonly string Bomb = GetCharacter("&#xf1e2");
		public static readonly string Book = GetCharacter("&#xf02d");
		public static readonly string Bookmark = GetCharacter("&#xf02e");
		public static readonly string BookmarkO = GetCharacter("&#xf097");
		public static readonly string Briefcase = GetCharacter("&#xf0b1");
		public static readonly string Btc = GetCharacter("&#xf15a");
		public static readonly string Bug = GetCharacter("&#xf188");
		public static readonly string Building = GetCharacter("&#xf1ad");
		public static readonly string BuildingO = GetCharacter("&#xf0f7");
		public static readonly string Bullhorn = GetCharacter("&#xf0a1");
		public static readonly string Bullseye = GetCharacter("&#xf140");
		public static readonly string Bus = GetCharacter("&#xf207");
		public static readonly string Cab = GetCharacter("&#xf1ba");
		public static readonly string Calculator = GetCharacter("&#xf1ec");
		public static readonly string Calendar = GetCharacter("&#xf073");
		public static readonly string CalendarO = GetCharacter("&#xf133");
		public static readonly string Camera = GetCharacter("&#xf030");
		public static readonly string CameraRetro = GetCharacter("&#xf083");
		public static readonly string Car = GetCharacter("&#xf1b9");
		public static readonly string CaretDown = GetCharacter("&#xf0d7");
		public static readonly string CaretLeft = GetCharacter("&#xf0d9");
		public static readonly string CaretRight = GetCharacter("&#xf0da");
		public static readonly string CaretSquareODown = GetCharacter("&#xf150");
		public static readonly string CaretSquareOLeft = GetCharacter("&#xf191");
		public static readonly string CaretSquareORight = GetCharacter("&#xf152");
		public static readonly string CaretSquareOUp = GetCharacter("&#xf151");
		public static readonly string CaretUp = GetCharacter("&#xf0d8");
		public static readonly string Cc = GetCharacter("&#xf20a");
		public static readonly string CcAmex = GetCharacter("&#xf1f3");
		public static readonly string CcDiscover = GetCharacter("&#xf1f2");
		public static readonly string CcMastercard = GetCharacter("&#xf1f1");
		public static readonly string CcPaypal = GetCharacter("&#xf1f4");
		public static readonly string CcStripe = GetCharacter("&#xf1f5");
		public static readonly string CcVisa = GetCharacter("&#xf1f0");
		public static readonly string Certificate = GetCharacter("&#xf0a3");
		public static readonly string Chain = GetCharacter("&#xf0c1");
		public static readonly string ChainBroken = GetCharacter("&#xf127");
		public static readonly string Check = GetCharacter("&#xf00c");
		public static readonly string CheckCircle = GetCharacter("&#xf058");
		public static readonly string CheckCircleO = GetCharacter("&#xf05d");
		public static readonly string CheckSquare = GetCharacter("&#xf14a");
		public static readonly string CheckSquareO = GetCharacter("&#xf046");
		public static readonly string ChevronCircleDown = GetCharacter("&#xf13a");
		public static readonly string ChevronCircleLeft = GetCharacter("&#xf137");
		public static readonly string ChevronCircleRight = GetCharacter("&#xf138");
		public static readonly string ChevronCircleUp = GetCharacter("&#xf139");
		public static readonly string ChevronDown = GetCharacter("&#xf078");
		public static readonly string ChevronLeft = GetCharacter("&#xf053");
		public static readonly string ChevronRight = GetCharacter("&#xf054");
		public static readonly string ChevronUp = GetCharacter("&#xf077");
		public static readonly string Child = GetCharacter("&#xf1ae");
		public static readonly string Circle = GetCharacter("&#xf111");
		public static readonly string CircleO = GetCharacter("&#xf10c");
		public static readonly string CircleONotch = GetCharacter("&#xf1ce");
		public static readonly string CircleThin = GetCharacter("&#xf1db");
		public static readonly string Clipboard = GetCharacter("&#xf0ea");
		public static readonly string ClockO = GetCharacter("&#xf017");
		public static readonly string Close = GetCharacter("&#xf00d");
		public static readonly string Cloud = GetCharacter("&#xf0c2");
		public static readonly string CloudDownload = GetCharacter("&#xf0ed");
		public static readonly string CloudUpload = GetCharacter("&#xf0ee");
		public static readonly string Cny = GetCharacter("&#xf157");
		public static readonly string Code = GetCharacter("&#xf121");
		public static readonly string CodeFork = GetCharacter("&#xf126");
		public static readonly string Codepen = GetCharacter("&#xf1cb");
		public static readonly string Coffee = GetCharacter("&#xf0f4");
		public static readonly string Cog = GetCharacter("&#xf013");
		public static readonly string Cogs = GetCharacter("&#xf085");
		public static readonly string Columns = GetCharacter("&#xf0db");
		public static readonly string Comment = GetCharacter("&#xf075");
		public static readonly string CommentO = GetCharacter("&#xf0e5");
		public static readonly string Comments = GetCharacter("&#xf086");
		public static readonly string CommentsO = GetCharacter("&#xf0e6");
		public static readonly string Compass = GetCharacter("&#xf14e");
		public static readonly string Compress = GetCharacter("&#xf066");
		public static readonly string Copy = GetCharacter("&#xf0c5");
		public static readonly string Copyright = GetCharacter("&#xf1f9");
		public static readonly string CreditCard = GetCharacter("&#xf09d");
		public static readonly string Crop = GetCharacter("&#xf125");
		public static readonly string Crosshairs = GetCharacter("&#xf05b");
		public static readonly string Css3 = GetCharacter("&#xf13c");
		public static readonly string Cube = GetCharacter("&#xf1b2");
		public static readonly string Cubes = GetCharacter("&#xf1b3");
		public static readonly string Cut = GetCharacter("&#xf0c4");
		public static readonly string Cutlery = GetCharacter("&#xf0f5");
		public static readonly string Dashboard = GetCharacter("&#xf0e4");
		public static readonly string Database = GetCharacter("&#xf1c0");
		public static readonly string Dedent = GetCharacter("&#xf03b");
		public static readonly string Delicious = GetCharacter("&#xf1a5");
		public static readonly string Desktop = GetCharacter("&#xf108");
		public static readonly string Deviantart = GetCharacter("&#xf1bd");
		public static readonly string Digg = GetCharacter("&#xf1a6");
		public static readonly string Dollar = GetCharacter("&#xf155");
		public static readonly string DotCircleO = GetCharacter("&#xf192");
		public static readonly string Download = GetCharacter("&#xf019");
		public static readonly string Dribbble = GetCharacter("&#xf17d");
		public static readonly string Dropbox = GetCharacter("&#xf16b");
		public static readonly string Drupal = GetCharacter("&#xf1a9");
		public static readonly string Edit = GetCharacter("&#xf044");
		public static readonly string Eject = GetCharacter("&#xf052");
		public static readonly string EllipsisH = GetCharacter("&#xf141");
		public static readonly string EllipsisV = GetCharacter("&#xf142");
		public static readonly string Empire = GetCharacter("&#xf1d1");
		public static readonly string Envelope = GetCharacter("&#xf0e0");
		public static readonly string EnvelopeO = GetCharacter("&#xf003");
		public static readonly string EnvelopeSquare = GetCharacter("&#xf199");
		public static readonly string Eraser = GetCharacter("&#xf12d");
		public static readonly string Eur = GetCharacter("&#xf153");
		public static readonly string Euro = GetCharacter("&#xf153");
		public static readonly string Exchange = GetCharacter("&#xf0ec");
		public static readonly string Exclamation = GetCharacter("&#xf12a");
		public static readonly string ExclamationCircle = GetCharacter("&#xf06a");
		public static readonly string ExclamationTriangle = GetCharacter("&#xf071");
		public static readonly string Expand = GetCharacter("&#xf065");
		public static readonly string ExternalLink = GetCharacter("&#xf08e");
		public static readonly string ExternalLinkSquare = GetCharacter("&#xf14c");
		public static readonly string Eye = GetCharacter("&#xf06e");
		public static readonly string EyeSlash = GetCharacter("&#xf070");
		public static readonly string Eyedropper = GetCharacter("&#xf1fb");
		public static readonly string Facebook = GetCharacter("&#xf09a");
		public static readonly string FacebookSquare = GetCharacter("&#xf082");
		public static readonly string FastBackward = GetCharacter("&#xf049");
		public static readonly string FastForward = GetCharacter("&#xf050");
		public static readonly string Fax = GetCharacter("&#xf1ac");
		public static readonly string Female = GetCharacter("&#xf182");
		public static readonly string FighterJet = GetCharacter("&#xf0fb");
		public static readonly string File = GetCharacter("&#xf15b");
		public static readonly string FileArchiveO = GetCharacter("&#xf1c6");
		public static readonly string FileAudioO = GetCharacter("&#xf1c7");
		public static readonly string FileCodeO = GetCharacter("&#xf1c9");
		public static readonly string FileExcelO = GetCharacter("&#xf1c3");
		public static readonly string FileImageO = GetCharacter("&#xf1c5");
		public static readonly string FileMovieO = GetCharacter("&#xf1c8");
		public static readonly string FileO = GetCharacter("&#xf016");
		public static readonly string FilePdfO = GetCharacter("&#xf1c1");
		public static readonly string FilePhotoO = GetCharacter("&#xf1c5");
		public static readonly string FilePictureO = GetCharacter("&#xf1c5");
		public static readonly string FilePowerpointO = GetCharacter("&#xf1c4");
		public static readonly string FileSoundO = GetCharacter("&#xf1c7");
		public static readonly string FileText = GetCharacter("&#xf15c");
		public static readonly string FileTextO = GetCharacter("&#xf0f6");
		public static readonly string FileVideoO = GetCharacter("&#xf1c8");
		public static readonly string FileWordO = GetCharacter("&#xf1c2");
		public static readonly string FileZipO = GetCharacter("&#xf1c6");
		public static readonly string FilesO = GetCharacter("&#xf0c5");
		public static readonly string Film = GetCharacter("&#xf008");
		public static readonly string Filter = GetCharacter("&#xf0b0");
		public static readonly string Fire = GetCharacter("&#xf06d");
		public static readonly string FireExtinguisher = GetCharacter("&#xf134");
		public static readonly string Flag = GetCharacter("&#xf024");
		public static readonly string FlagCheckered = GetCharacter("&#xf11e");
		public static readonly string FlagO = GetCharacter("&#xf11d");
		public static readonly string Flash = GetCharacter("&#xf0e7");
		public static readonly string Flask = GetCharacter("&#xf0c3");
		public static readonly string Flickr = GetCharacter("&#xf16e");
		public static readonly string FloppyO = GetCharacter("&#xf0c7");
		public static readonly string Folder = GetCharacter("&#xf07b");
		public static readonly string FolderO = GetCharacter("&#xf114");
		public static readonly string FolderOpen = GetCharacter("&#xf07c");
		public static readonly string FolderOpenO = GetCharacter("&#xf115");
		public static readonly string Font = GetCharacter("&#xf031");
		public static readonly string Forward = GetCharacter("&#xf04e");
		public static readonly string Foursquare = GetCharacter("&#xf180");
		public static readonly string FrownO = GetCharacter("&#xf119");
		public static readonly string FutbolO = GetCharacter("&#xf1e3");
		public static readonly string Gamepad = GetCharacter("&#xf11b");
		public static readonly string Gavel = GetCharacter("&#xf0e3");
		public static readonly string Gbp = GetCharacter("&#xf154");
		public static readonly string Ge = GetCharacter("&#xf1d1");
		public static readonly string Gear = GetCharacter("&#xf013");
		public static readonly string Gears = GetCharacter("&#xf085");
		public static readonly string Gift = GetCharacter("&#xf06b");
		public static readonly string Git = GetCharacter("&#xf1d3");
		public static readonly string GitSquare = GetCharacter("&#xf1d2");
		public static readonly string Github = GetCharacter("&#xf09b");
		public static readonly string GithubAlt = GetCharacter("&#xf113");
		public static readonly string GithubSquare = GetCharacter("&#xf092");
		public static readonly string Gittip = GetCharacter("&#xf184");
		public static readonly string Glass = GetCharacter("&#xf000");
		public static readonly string Globe = GetCharacter("&#xf0ac");
		public static readonly string Google = GetCharacter("&#xf1a0");
		public static readonly string GooglePlus = GetCharacter("&#xf0d5");
		public static readonly string GooglePlusSquare = GetCharacter("&#xf0d4");
		public static readonly string GoogleWallet = GetCharacter("&#xf1ee");
		public static readonly string GraduationCap = GetCharacter("&#xf19d");
		public static readonly string Group = GetCharacter("&#xf0c0");
		public static readonly string HSquare = GetCharacter("&#xf0fd");
		public static readonly string HackerNews = GetCharacter("&#xf1d4");
		public static readonly string HandODown = GetCharacter("&#xf0a7");
		public static readonly string HandOLeft = GetCharacter("&#xf0a5");
		public static readonly string HandORight = GetCharacter("&#xf0a4");
		public static readonly string HandOUp = GetCharacter("&#xf0a6");
		public static readonly string HddO = GetCharacter("&#xf0a0");
		public static readonly string Header = GetCharacter("&#xf1dc");
		public static readonly string Headphones = GetCharacter("&#xf025");
		public static readonly string Heart = GetCharacter("&#xf004");
		public static readonly string HeartO = GetCharacter("&#xf08a");
		public static readonly string History = GetCharacter("&#xf1da");
		public static readonly string Home = GetCharacter("&#xf015");
		public static readonly string HospitalO = GetCharacter("&#xf0f8");
		public static readonly string Html5 = GetCharacter("&#xf13b");
		public static readonly string Ils = GetCharacter("&#xf20b");
		public static readonly string Image = GetCharacter("&#xf03e");
		public static readonly string Inbox = GetCharacter("&#xf01c");
		public static readonly string Indent = GetCharacter("&#xf03c");
		public static readonly string Info = GetCharacter("&#xf129");
		public static readonly string InfoCircle = GetCharacter("&#xf05a");
		public static readonly string Inr = GetCharacter("&#xf156");
		public static readonly string Instagram = GetCharacter("&#xf16d");
		public static readonly string Institution = GetCharacter("&#xf19c");
		public static readonly string Ioxhost = GetCharacter("&#xf208");
		public static readonly string Italic = GetCharacter("&#xf033");
		public static readonly string Joomla = GetCharacter("&#xf1aa");
		public static readonly string Jpy = GetCharacter("&#xf157");
		public static readonly string Jsfiddle = GetCharacter("&#xf1cc");
		public static readonly string Key = GetCharacter("&#xf084");
		public static readonly string KeyboardO = GetCharacter("&#xf11c");
		public static readonly string Krw = GetCharacter("&#xf159");
		public static readonly string Language = GetCharacter("&#xf1ab");
		public static readonly string Laptop = GetCharacter("&#xf109");
		public static readonly string Lastfm = GetCharacter("&#xf202");
		public static readonly string LastfmSquare = GetCharacter("&#xf203");
		public static readonly string Leaf = GetCharacter("&#xf06c");
		public static readonly string Legal = GetCharacter("&#xf0e3");
		public static readonly string LemonO = GetCharacter("&#xf094");
		public static readonly string LevelDown = GetCharacter("&#xf149");
		public static readonly string LevelUp = GetCharacter("&#xf148");
		public static readonly string LifeBouy = GetCharacter("&#xf1cd");
		public static readonly string LifeBuoy = GetCharacter("&#xf1cd");
		public static readonly string LifeRing = GetCharacter("&#xf1cd");
		public static readonly string LifeSaver = GetCharacter("&#xf1cd");
		public static readonly string LightbulbO = GetCharacter("&#xf0eb");
		public static readonly string LineChart = GetCharacter("&#xf201");
		public static readonly string Link = GetCharacter("&#xf0c1");
		public static readonly string Linkedin = GetCharacter("&#xf0e1");
		public static readonly string LinkedinSquare = GetCharacter("&#xf08c");
		public static readonly string Linux = GetCharacter("&#xf17c");
		public static readonly string List = GetCharacter("&#xf03a");
		public static readonly string ListAlt = GetCharacter("&#xf022");
		public static readonly string ListOl = GetCharacter("&#xf0cb");
		public static readonly string ListUl = GetCharacter("&#xf0ca");
		public static readonly string LocationArrow = GetCharacter("&#xf124");
		public static readonly string Lock = GetCharacter("&#xf023");
		public static readonly string LongArrowDown = GetCharacter("&#xf175");
		public static readonly string LongArrowLeft = GetCharacter("&#xf177");
		public static readonly string LongArrowRight = GetCharacter("&#xf178");
		public static readonly string LongArrowUp = GetCharacter("&#xf176");
		public static readonly string Magic = GetCharacter("&#xf0d0");
		public static readonly string Magnet = GetCharacter("&#xf076");
		public static readonly string MailForward = GetCharacter("&#xf064");
		public static readonly string MailReply = GetCharacter("&#xf112");
		public static readonly string MailReplyAll = GetCharacter("&#xf122");
		public static readonly string Male = GetCharacter("&#xf183");
		public static readonly string MapMarker = GetCharacter("&#xf041");
		public static readonly string Maxcdn = GetCharacter("&#xf136");
		public static readonly string Meanpath = GetCharacter("&#xf20c");
		public static readonly string Medkit = GetCharacter("&#xf0fa");
		public static readonly string MehO = GetCharacter("&#xf11a");
		public static readonly string Microphone = GetCharacter("&#xf130");
		public static readonly string MicrophoneSlash = GetCharacter("&#xf131");
		public static readonly string Minus = GetCharacter("&#xf068");
		public static readonly string MinusCircle = GetCharacter("&#xf056");
		public static readonly string MinusSquare = GetCharacter("&#xf146");
		public static readonly string MinusSquareO = GetCharacter("&#xf147");
		public static readonly string Mobile = GetCharacter("&#xf10b");
		public static readonly string MobilePhone = GetCharacter("&#xf10b");
		public static readonly string Money = GetCharacter("&#xf0d6");
		public static readonly string MoonO = GetCharacter("&#xf186");
		public static readonly string MortarBoard = GetCharacter("&#xf19d");
		public static readonly string Music = GetCharacter("&#xf001");
		public static readonly string Navicon = GetCharacter("&#xf0c9");
		public static readonly string NewspaperO = GetCharacter("&#xf1ea");
		public static readonly string Openid = GetCharacter("&#xf19b");
		public static readonly string Outdent = GetCharacter("&#xf03b");
		public static readonly string Pagelines = GetCharacter("&#xf18c");
		public static readonly string PaintBrush = GetCharacter("&#xf1fc");
		public static readonly string PaperPlane = GetCharacter("&#xf1d8");
		public static readonly string PaperPlaneO = GetCharacter("&#xf1d9");
		public static readonly string Paperclip = GetCharacter("&#xf0c6");
		public static readonly string Paragraph = GetCharacter("&#xf1dd");
		public static readonly string Paste = GetCharacter("&#xf0ea");
		public static readonly string Pause = GetCharacter("&#xf04c");
		public static readonly string Paw = GetCharacter("&#xf1b0");
		public static readonly string Paypal = GetCharacter("&#xf1ed");
		public static readonly string Pencil = GetCharacter("&#xf040");
		public static readonly string PencilSquare = GetCharacter("&#xf14b");
		public static readonly string PencilSquareO = GetCharacter("&#xf044");
		public static readonly string Phone = GetCharacter("&#xf095");
		public static readonly string PhoneSquare = GetCharacter("&#xf098");
		public static readonly string Photo = GetCharacter("&#xf03e");
		public static readonly string PictureO = GetCharacter("&#xf03e");
		public static readonly string PieChart = GetCharacter("&#xf200");
		public static readonly string PiedPiper = GetCharacter("&#xf1a7");
		public static readonly string PiedPiperAlt = GetCharacter("&#xf1a8");
		public static readonly string Pinterest = GetCharacter("&#xf0d2");
		public static readonly string PinterestSquare = GetCharacter("&#xf0d3");
		public static readonly string Plane = GetCharacter("&#xf072");
		public static readonly string Play = GetCharacter("&#xf04b");
		public static readonly string PlayCircle = GetCharacter("&#xf144");
		public static readonly string PlayCircleO = GetCharacter("&#xf01d");
		public static readonly string Plug = GetCharacter("&#xf1e6");
		public static readonly string Plus = GetCharacter("&#xf067");
		public static readonly string PlusCircle = GetCharacter("&#xf055");
		public static readonly string PlusSquare = GetCharacter("&#xf0fe");
		public static readonly string PlusSquareO = GetCharacter("&#xf196");
		public static readonly string PowerOff = GetCharacter("&#xf011");
		public static readonly string Print = GetCharacter("&#xf02f");
		public static readonly string PuzzlePiece = GetCharacter("&#xf12e");
		public static readonly string Qq = GetCharacter("&#xf1d6");
		public static readonly string Qrcode = GetCharacter("&#xf029");
		public static readonly string Question = GetCharacter("&#xf128");
		public static readonly string QuestionCircle = GetCharacter("&#xf059");
		public static readonly string QuoteLeft = GetCharacter("&#xf10d");
		public static readonly string QuoteRight = GetCharacter("&#xf10e");
		public static readonly string Ra = GetCharacter("&#xf1d0");
		public static readonly string Random = GetCharacter("&#xf074");
		public static readonly string Rebel = GetCharacter("&#xf1d0");
		public static readonly string Recycle = GetCharacter("&#xf1b8");
		public static readonly string Reddit = GetCharacter("&#xf1a1");
		public static readonly string RedditSquare = GetCharacter("&#xf1a2");
		public static readonly string Refresh = GetCharacter("&#xf021");
		public static readonly string Remove = GetCharacter("&#xf00d");
		public static readonly string Renren = GetCharacter("&#xf18b");
		public static readonly string Reorder = GetCharacter("&#xf0c9");
		public static readonly string Repeat = GetCharacter("&#xf01e");
		public static readonly string Reply = GetCharacter("&#xf112");
		public static readonly string ReplyAll = GetCharacter("&#xf122");
		public static readonly string Retweet = GetCharacter("&#xf079");
		public static readonly string Rmb = GetCharacter("&#xf157");
		public static readonly string Road = GetCharacter("&#xf018");
		public static readonly string Rocket = GetCharacter("&#xf135");
		public static readonly string RotateLeft = GetCharacter("&#xf0e2");
		public static readonly string RotateRight = GetCharacter("&#xf01e");
		public static readonly string Rouble = GetCharacter("&#xf158");
		public static readonly string Rss = GetCharacter("&#xf09e");
		public static readonly string RssSquare = GetCharacter("&#xf143");
		public static readonly string Rub = GetCharacter("&#xf158");
		public static readonly string Ruble = GetCharacter("&#xf158");
		public static readonly string Rupee = GetCharacter("&#xf156");
		public static readonly string Save = GetCharacter("&#xf0c7");
		public static readonly string Scissors = GetCharacter("&#xf0c4");
		public static readonly string Search = GetCharacter("&#xf002");
		public static readonly string SearchMinus = GetCharacter("&#xf010");
		public static readonly string SearchPlus = GetCharacter("&#xf00e");
		public static readonly string Send = GetCharacter("&#xf1d8");
		public static readonly string SendO = GetCharacter("&#xf1d9");
		public static readonly string Share = GetCharacter("&#xf064");
		public static readonly string ShareAlt = GetCharacter("&#xf1e0");
		public static readonly string ShareAltSquare = GetCharacter("&#xf1e1");
		public static readonly string ShareSquare = GetCharacter("&#xf14d");
		public static readonly string ShareSquareO = GetCharacter("&#xf045");
		public static readonly string Shekel = GetCharacter("&#xf20b");
		public static readonly string Sheqel = GetCharacter("&#xf20b");
		public static readonly string Shield = GetCharacter("&#xf132");
		public static readonly string ShoppingCart = GetCharacter("&#xf07a");
		public static readonly string SignIn = GetCharacter("&#xf090");
		public static readonly string SignOut = GetCharacter("&#xf08b");
		public static readonly string Signal = GetCharacter("&#xf012");
		public static readonly string Sitemap = GetCharacter("&#xf0e8");
		public static readonly string Skype = GetCharacter("&#xf17e");
		public static readonly string Slack = GetCharacter("&#xf198");
		public static readonly string Sliders = GetCharacter("&#xf1de");
		public static readonly string Slideshare = GetCharacter("&#xf1e7");
		public static readonly string SmileO = GetCharacter("&#xf118");
		public static readonly string SoccerBallO = GetCharacter("&#xf1e3");
		public static readonly string Sort = GetCharacter("&#xf0dc");
		public static readonly string SortAlphaAsc = GetCharacter("&#xf15d");
		public static readonly string SortAlphaDesc = GetCharacter("&#xf15e");
		public static readonly string SortAmountAsc = GetCharacter("&#xf160");
		public static readonly string SortAmountDesc = GetCharacter("&#xf161");
		public static readonly string SortAsc = GetCharacter("&#xf0de");
		public static readonly string SortDesc = GetCharacter("&#xf0dd");
		public static readonly string SortDown = GetCharacter("&#xf0dd");
		public static readonly string SortNumericAsc = GetCharacter("&#xf162");
		public static readonly string SortNumericDesc = GetCharacter("&#xf163");
		public static readonly string SortUp = GetCharacter("&#xf0de");
		public static readonly string Soundcloud = GetCharacter("&#xf1be");
		public static readonly string SpaceShuttle = GetCharacter("&#xf197");
		public static readonly string Spinner = GetCharacter("&#xf110");
		public static readonly string Spoon = GetCharacter("&#xf1b1");
		public static readonly string Spotify = GetCharacter("&#xf1bc");
		public static readonly string Square = GetCharacter("&#xf0c8");
		public static readonly string SquareO = GetCharacter("&#xf096");
		public static readonly string StackExchange = GetCharacter("&#xf18d");
		public static readonly string StackOverflow = GetCharacter("&#xf16c");
		public static readonly string Star = GetCharacter("&#xf005");
		public static readonly string StarHalf = GetCharacter("&#xf089");
		public static readonly string StarHalfEmpty = GetCharacter("&#xf123");
		public static readonly string StarHalfFull = GetCharacter("&#xf123");
		public static readonly string StarHalfO = GetCharacter("&#xf123");
		public static readonly string StarO = GetCharacter("&#xf006");
		public static readonly string Steam = GetCharacter("&#xf1b6");
		public static readonly string SteamSquare = GetCharacter("&#xf1b7");
		public static readonly string StepBackward = GetCharacter("&#xf048");
		public static readonly string StepForward = GetCharacter("&#xf051");
		public static readonly string Stethoscope = GetCharacter("&#xf0f1");
		public static readonly string Stop = GetCharacter("&#xf04d");
		public static readonly string Strikethrough = GetCharacter("&#xf0cc");
		public static readonly string Stumbleupon = GetCharacter("&#xf1a4");
		public static readonly string StumbleuponCircle = GetCharacter("&#xf1a3");
		public static readonly string Subscript = GetCharacter("&#xf12c");
		public static readonly string Suitcase = GetCharacter("&#xf0f2");
		public static readonly string SunO = GetCharacter("&#xf185");
		public static readonly string Superscript = GetCharacter("&#xf12b");
		public static readonly string Support = GetCharacter("&#xf1cd");
		public static readonly string Table = GetCharacter("&#xf0ce");
		public static readonly string Tablet = GetCharacter("&#xf10a");
		public static readonly string Tachometer = GetCharacter("&#xf0e4");
		public static readonly string Tag = GetCharacter("&#xf02b");
		public static readonly string Tags = GetCharacter("&#xf02c");
		public static readonly string Tasks = GetCharacter("&#xf0ae");
		public static readonly string Taxi = GetCharacter("&#xf1ba");
		public static readonly string TencentWeibo = GetCharacter("&#xf1d5");
		public static readonly string Terminal = GetCharacter("&#xf120");
		public static readonly string TextHeight = GetCharacter("&#xf034");
		public static readonly string TextWidth = GetCharacter("&#xf035");
		public static readonly string Th = GetCharacter("&#xf00a");
		public static readonly string ThLarge = GetCharacter("&#xf009");
		public static readonly string ThList = GetCharacter("&#xf00b");
		public static readonly string ThumbTack = GetCharacter("&#xf08d");
		public static readonly string ThumbsDown = GetCharacter("&#xf165");
		public static readonly string ThumbsODown = GetCharacter("&#xf088");
		public static readonly string ThumbsOUp = GetCharacter("&#xf087");
		public static readonly string ThumbsUp = GetCharacter("&#xf164");
		public static readonly string Ticket = GetCharacter("&#xf145");
		public static readonly string Times = GetCharacter("&#xf00d");
		public static readonly string TimesCircle = GetCharacter("&#xf057");
		public static readonly string TimesCircleO = GetCharacter("&#xf05c");
		public static readonly string Tint = GetCharacter("&#xf043");
		public static readonly string ToggleDown = GetCharacter("&#xf150");
		public static readonly string ToggleLeft = GetCharacter("&#xf191");
		public static readonly string ToggleOff = GetCharacter("&#xf204");
		public static readonly string ToggleOn = GetCharacter("&#xf205");
		public static readonly string ToggleRight = GetCharacter("&#xf152");
		public static readonly string ToggleUp = GetCharacter("&#xf151");
		public static readonly string Trash = GetCharacter("&#xf1f8");
		public static readonly string TrashO = GetCharacter("&#xf014");
		public static readonly string Tree = GetCharacter("&#xf1bb");
		public static readonly string Trello = GetCharacter("&#xf181");
		public static readonly string Trophy = GetCharacter("&#xf091");
		public static readonly string Truck = GetCharacter("&#xf0d1");
		public static readonly string Try = GetCharacter("&#xf195");
		public static readonly string Tty = GetCharacter("&#xf1e4");
		public static readonly string Tumblr = GetCharacter("&#xf173");
		public static readonly string TumblrSquare = GetCharacter("&#xf174");
		public static readonly string TurkishLira = GetCharacter("&#xf195");
		public static readonly string Twitch = GetCharacter("&#xf1e8");
		public static readonly string Twitter = GetCharacter("&#xf099");
		public static readonly string TwitterSquare = GetCharacter("&#xf081");
		public static readonly string Umbrella = GetCharacter("&#xf0e9");
		public static readonly string Underline = GetCharacter("&#xf0cd");
		public static readonly string Undo = GetCharacter("&#xf0e2");
		public static readonly string University = GetCharacter("&#xf19c");
		public static readonly string Unlink = GetCharacter("&#xf127");
		public static readonly string Unlock = GetCharacter("&#xf09c");
		public static readonly string UnlockAlt = GetCharacter("&#xf13e");
		public static readonly string Unsorted = GetCharacter("&#xf0dc");
		public static readonly string Upload = GetCharacter("&#xf093");
		public static readonly string Usd = GetCharacter("&#xf155");
		public static readonly string User = GetCharacter("&#xf007");
		public static readonly string UserMd = GetCharacter("&#xf0f0");
		public static readonly string Users = GetCharacter("&#xf0c0");
		public static readonly string VideoCamera = GetCharacter("&#xf03d");
		public static readonly string VimeoSquare = GetCharacter("&#xf194");
		public static readonly string Vine = GetCharacter("&#xf1ca");
		public static readonly string Vk = GetCharacter("&#xf189");
		public static readonly string VolumeDown = GetCharacter("&#xf027");
		public static readonly string VolumeOff = GetCharacter("&#xf026");
		public static readonly string VolumeUp = GetCharacter("&#xf028");
		public static readonly string Warning = GetCharacter("&#xf071");
		public static readonly string Wechat = GetCharacter("&#xf1d7");
		public static readonly string Weibo = GetCharacter("&#xf18a");
		public static readonly string Weixin = GetCharacter("&#xf1d7");
		public static readonly string Wheelchair = GetCharacter("&#xf193");
		public static readonly string Wifi = GetCharacter("&#xf1eb");
		public static readonly string Windows = GetCharacter("&#xf17a");
		public static readonly string Won = GetCharacter("&#xf159");
		public static readonly string Wordpress = GetCharacter("&#xf19a");
		public static readonly string Wrench = GetCharacter("&#xf0ad");
		public static readonly string Xing = GetCharacter("&#xf168");
		public static readonly string XingSquare = GetCharacter("&#xf169");
		public static readonly string Yahoo = GetCharacter("&#xf19e");
		public static readonly string Yelp = GetCharacter("&#xf1e9");
		public static readonly string Yen = GetCharacter("&#xf157");
		public static readonly string Youtube = GetCharacter("&#xf167");
		public static readonly string YoutubePlay = GetCharacter("&#xf16a");
		public static readonly string YoutubeSquare = GetCharacter("&#xf166");

        private static string GetCharacter(string unicode)
        {
            unicode = unicode.Replace("&#x", string.Empty);
            unicode = unicode.TrimEnd(';');

            var code = int.Parse(unicode, NumberStyles.AllowHexSpecifier);
            return ((char)code).ToString();
        }
    }
}
