using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OEYBS.Entities.Concrete;

namespace OEYBS.DataAccess.Concrete.EntityFramework
{
    public class MyIntializer : CreateDatabaseIfNotExists<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            DateTime now = DateTime.Now.AddDays(-5);

            string[] LastNameList = {"ABACIOĞLU","ABAT","ABSEYİ","ACAR","ACARBULUT","AÇAR","AÇIKGÖZ","ADALI","ADANIR","ADIGÜZEL","AKTAŞ",
                "AKTEMUR","AKTUĞ","AKTÜRK","AKYILMAZ","AKYOL","AKYÜREK","AKYÜZ","AL","ALABALIK","ALADAĞ","ALAN","ALAY","ALAYBEYOĞLU",
                "ALBAŞ","ALBAY","ALBAYRAK","ALBEN","ALBOĞA","ALDİNÇ","ALĞAN","ALICI","ALIM","ALIMLI","BAKLACI","BAKLALI","BAL","BALABAN","BALAL","BALCI","BALLI","BALOĞLU","BALSAK","BALTA",
                "BALTACI","BARAN","BARATALI","BARBAROS","BARÇA","BARÇAK","BARDAKÇI","BARIŞAN","BARUT","BAŞ","BAŞAK","BAŞAR","BAŞARAN","BAŞARGAN","BAŞCI","BAŞDAŞ","BAŞER","BİÇER","BİLAL","BİLGE","BİLGİ","BİLGİÇ","BİLGİN","BİLİCİ","BİNBOĞA","BİNNETOĞLU","BİRİ","BOBUŞOĞLU","BODUROĞLU","BOĞAN","BOLAÇ","BOLAT","BOLATKALE","BOLATTÜRK","BOLKAN","BOLSOY","BOSTANKOLU",
                "BOZAN","BOZARSLAN","BOZKURT","BOZKURTER","BOZKUŞ","BOZOĞLAN","BOZOĞLU","BOZPOLAT","BÖCÜ","BÖLÜK","BÖLÜKBAŞ","BÖRTA","BÖYÜK","BUDUNOĞLU","BUĞRUL","BULAKÇI","BULUÇ","BULUR","BULUT","BURAK","BURULDAY","BÜBER","BÜDÜN","BÜKÜLMEZ","ÇATUK","ÇAVDAR","ÇAVLI","ÇAY","ÇAYLI","ÇEÇEN","ÇEKİÇ","ÇELEBİ","ÇELEN","ÇELİK","ERGE","ERGİNEL","ERGİNTÜRK ACAR","ERGÖZ",
                "ERGÜLÜ EŞMEN","ERGÜN","ERKAN","ERKEN","ERKURAN","EROĞLU","EROL","ERSOY","ERSÖZ","ERŞEN","ERTAN","ERTAŞ","ERTEKİN","ERTEM","ERTÜRK","ERTÜRKLER","ERYAVUZ","ERYILMAZ","ERZURUM","GÖKGÜL","GÖKKOCA","GÖKMEYDAN","GÖKSEL","GÖKSOY","GÖKTAŞ","GÖKTEN","GÖKTEPE","GÖKTÜRK","GÖLEMEZ","GÖNCÜ","GÖRDÜK","GÖRENEKLİ","GÖRKEM","GÖRMELİ","GÖRMÜŞ","HATİPOĞLU",
                "HAVAS","HEPKAYA","HEYBET","HIDIROĞLU","HİÇDURMAZ","HİÇYILMAZ","HODJAOGLU","HOŞER","HÖKE","HÜSEYİNOĞLU","HÜSEYNİ","KARAAĞAÇ","KARAALP","KARAARSLAN","KARAASLAN","KARABAĞ","KARABULUT","KARACA","KARACAN","KARACAN ERŞEKERCİ","KARADAĞ","KARADAĞ GEÇGEL","KARADAŞ","KARADAVUT","KARADEMİR","KARADENİZ","KARADUMAN","KARADURAK","KARAGÖZ","KARAHAN",
                "KARAİSMAİLOĞLU","KARAKAN","KESİM","KESKİN","KEŞKEK","KEVKİR","KHALİL","KILAÇ","KILAVUZ","KILBACAK","KILIÇCIOĞLU","KILIÇOĞLU","KILINÇ","KINALIOĞLU","KINDIR","KINIK","KIR","KIRAÇ","KIRAN","KIRASLAN","KIRBAŞ","KIRCALI","KIRHAN","KÖSEOĞLU","KÖŞKER","KÖYCÜ","KÖYLÜ","KÖYLÜOĞLU","KUBAT","KUDAY","KUMBUL","KUMRAL","KUNAK","KURTULUŞ","KURU","KURUL",
                "NURLU","OCAK","OFLAZ","OFLAZOĞLU","OĞUZ","OĞUZSOY","OKÇU","OKTAY","OKUDAN","OKULU","OKUR","OLCAR","OLGAÇ","OLGEN","OLMAZ","OLPAK","OMAY","ONRAT","ONUK","ORAK","ORAL","ORDULU ŞAHİN","ORHAN","ORHON","ORMAN","ORTA","OSMANCA","OYNAK","OZAN","ÖCAL","ÖCALAN","ÖLKER","ÖNAL","ÖNAL MUSALAR",
                "ÖRDEK","ÖREN","ÖRENÇ","ÖRNEK","ÖTER","ÖZ","ÖZALP","ÖZANLAĞAN","ÖZASLAN","ÖZATA","ÖZAYDIN","ÖZBEK","ÖZBEY","ÖZBEYLER","ÖZCAN","ÖZCANLI","ÖZDEMİRKIRAN","ÖZDEN","ÖZDENOĞLU","ÖZER","ÖZER ÇELİK","ÖZGÜNER","ÖZGÜR","ÖZGÜROL","ÖZHAN","ÖZİŞ","ÖZKAN","ÖZKANLI","ÖZKAYA","ÖZKAYNAR","ÖZSAYIM","ÖZSOY","ÖZTAŞ","ÖZTOPRAK","ÖZTÜRK",
                "ÖZTÜRKERİ","ÖZÜAK","ÖZÜDOĞRU","ÖZYÖRÜK","PAKÖZ","PAKSOY","PARA","PARASIZ","PARLAK","PAZIR","PEHLİVAN","PEKDOĞAN","PEKEL","PEKER","PEKGÖZ","PEKTAŞ","PEYNİRCİ","PINARBAŞILI","PIRTI","PİRDOĞAN","PİRİ","PİRİM","PİŞİRGEN","POLAT","POSTALLI","POTA","PULAT","RENÇBER","SAATÇIOĞLU","SABAZ","SAÇLI","SADIÇ","SADUNOĞLU","SAF","SAĞ","SAĞCAN",
                "SAĞDIK","SAĞIR","SAĞLAM","SAK","SAKA","SAKALLI","SAKALLIOĞLU","SAKARYA","SALDIRAY","SALTÜRK","SANCAR","SANDAL","SANHAL","SANSARCI","SARAÇ","SARAL","SARAYLI","SARGIN","SARICANBAZ","SARIÇİÇEK","SARIEKİZ","SARIGÜL","SARIKAYA","SARİ","SARP","SAVAŞ","SAVĞA","SAVRAN","SAYGIN","SAYIN","SAYİNER",
                "SAYYİĞİT","SEÇİR","SEÇKİN","SEĞMEN","SEKİN","SELÇUK","SELİM","SELVAN","SELVİ","SELVİOĞLU","SEMERCİ","SENEMTAŞI","SERBEST","SERİN","SERT","SERTEL","SERTKAYA","SERTKAYAOĞLU","SERTOĞLU","SERVET","SEVEN","SEVER","SEVİMLİ","SEVİNÇ","SEVİNGİL","SEVÜK",
                "SEYHAN","SEYREK","SEYREKOĞLU","SEZEN","SEZER","SEZGİN","SINICI","SİĞA","SİL","SİPAHİ","SİVRİ","SOBAY","SOYDAN","ŞANLIER","ŞANLIKAN","ŞARLAK","ŞAŞMAZ","ŞİRİN","ŞİRZAİ","TACİR","TAHTACI","TALAN","TALAS","TAN","TANİN","TANİŞ","TARAKCI","TARKAN","TARLAN","TAŞ","TAŞAR","TAŞCI","TAŞDELEN","TAŞKIN","TAŞKIRAN","TAŞLI","TAŞMALI",
                "TAŞTEKİN","TATAR","TATLI","TAVŞAN","TAY","TAYFUN","TAYFUR","TAYYAR","TAZEOĞLU","TEĞİN","TEHLİ","TEKER","TEKİN","TEKİNSOY","TEMEL","TEMİZ","TEMLİ","TEMURTAŞ","TEN","TENEKECİ","TEOMAN","TEPE","TEVDİK","TEZEL","TEZER","TOHUMOĞLU","TOKAR","TOKAT","TOKATLIOĞLU","TOKER",
                "TOKMAK","TOKTAŞ","TOLA","TOLU","TOMBUL","TOPAK","TOPAL","TOPALKARA","TOPALOĞLU","TOPCUOĞLU","TOPÇU","TOPER","TOPKARA","TOPRAK","TOPTAŞ","TOPUZ","TOŞUR","TOY","TOYRAN","TOZLU","TÖNGE","TUĞCUGİL","TUNCAY","TUNCEL","TUNCER","TUNÇ","TUNÇAY","TURAÇ","TURAN","TURANOĞLU","TÜRKSOY","TÜRKYILMAZ","TÜTEN","UÇAR","UFACIK","UĞURLU","UĞUZ","ULAŞ","ULU","ULUBA","ULUBAŞOĞLU","ULUÖZ","ULUSOY",
                "ULUTAŞ","URAL","URFALI","URUÇ","USLU","USLUBAŞ","USLUSOY","USTA GÜÇ","USUL","UTLU","UYANIK","UYAR","UYGUR","UYĞUN","UYKUR","UYSAL","UZ","UZUN","UZUNCA","UZUNCAN","ÜÇER","ÜÇGÜL","ÜLGEN","ÜLGER","ÜLKEVAN","ÜNAL","ÜNALAN","ÜNGÜR","ÜNLÜ","ÜNSAL","ÜNÜŞ","ÜNÜVAR","ÜNVER","ÜREYEN","ÜRKMEZ","ÜRÜN","ÜSTÜN","YAKIŞAN",
                "YAKKAN","YAKUT","YALÇIN","YALÇINKAYA","YALINKILIÇ","YALNIZ","YAMAK","YAMAN","YANARDAĞ","YANCAR","YANIK","YANMAZ","YANNİ","YAPAR","YAPRAK","YARADILMIŞ","YARAR","YARBİL","YARDIMCI","YASA","YAYIKÇI","YAZAK","YEGİN","YEL","YENİAY","YENİÇERİ","YENİDOĞAN",
                "YENİDÜNYA","YENİGÜN","YENİLMEZ","YENİN","YERAL","YERLİKAYA","YEŞİL","YEŞİLDAĞER","YEŞİLFİDAN","YEŞİLKAYA","YÖNET","YÖRÜK","YUMAK","YUMURTAŞ","YURDAKÖK","YURDAM","YURDSEVEN","YURT","YURTDAŞ","YURTLU","YÜCE","YÜCEL",
                "YÜKSEL","YÜKSELMİŞ","YÜREK","YÜZBAŞIOĞLU","YÜZER","ZAİM","ZENGİN","ZEYBEK","ZEYLİ","ZİLELİGİL","ZUBAROĞLU"
            };

            string[] FirstNameList = {"Abdullah Arif","Abdullatif","Abdulmelik","Abdulsamet","Abdulselam","Abdulsemet",
                "Abdurrahman","Abdurrahman Fuat","Abdülkadir","Abdülsamet","Abide Merve","Abidin","Adem",
                "Adil","Adnan","Ahmad Taher","Ahmet","Ahmet Ali","Ahmet Bilgehan","Ahmet Burak","Ahmet Can","Ahmet Cevdet","Ahmet Çağrı","Ahmet Emre","Ahmet Furkan","Ahmet Gökhan","Ahmet Kürşad","Ahmet Melih","Ahmet Mert",
                "Ahmet Sercan","Ahmet Serkan","Ahmet Tunç","Ahmetcan","Akın","Aksel","Alaaddin","Alev","Alevtina",
                "Ali","Ali Burç","Ali Haluk","Ali Hasan","Ali Kemal","Ali Muharrem","Ali Ozan","Ali Rıza","Ali Said","Ali Saip",
                "Ali Seçkin","Alişan","Almala Pınar","Alp","Alper","Alperen","Andaç","Anıl","Arda","Arda Nermin","Arif","Arife Esra","Arman",
                "Arzu","Asena","Asım","Asiye Burcu","Aslan","Aslı","Aslıhan","Aslıhan Esra","Asudan Tuğçe","Asuman","Atacan","Atakan","Atılgan","Atilla","Atilla Süleyman","Atiye Meltem","Aybegüm","Aybüke","Aycan","Aycan Özden","Aydemir","Aydın","Aydoğan","Ayhan","Aykan",
                "Aykut","Ayla","Aylia","Aylin","Aylin Sevil","Aysel","Aysu","Aysun","Ayşe","Ayşe Ahsen","Ayşe Ceren","Ayşe Fulya","Ayşe Gizem","Ayşe Gül","Ayşe Gülçin",
                "Ayşe Nur","Ayşe Pınar","Ayşegül","Ayşen","Ayşenur","Aytaç","Aziz","Bahadır","Bahattin","Bahri","Baki","Bala Başak",
                "Baran","Barış","Başak","Baturay Kansu","Baver","Bayram","Bayram Furkan","Bedreddin","Bedri","Bedriye Müge","Begüm",
                "Bekir","Belgin","Belgin Emine","Belma","Bengü","Bengühan","Benhur Şirvan","Beraat","Beray","Berçem","Berfin","Berfin Can","Berfu","Beril Gülüş","Berk","Berkan","Berker","Berna","Berrin","Beste","Betül","Betül Emine","Beyza","Bilal","Bilal Barış","Bilge","Bilge Merve","Bilgi","Bilgin","Binnur","Bireylül","Birgül","Birol","Birsen","Bişar","Bora","Buğra","Bulut","Burak","Burcu","Burçhan","Burçin",
                "Burçin Meryem","Burhan","Burhanettin","Buşra","Bülent","Bünyamin","Büşra","Büşra Sultan","Cafer","Cahit","Can",
                "Canan","Caner","Cansen","Cansu","Cansu Selcan","Cebbar","Cebrail","Cem","Cem Atakan","Cem İnan","Cem Özgür","Cem Yaşar","Cemal",
                "Cemil","Cemile Ayşe","Cemile Çiğdem","Cemre","Cengiz","Cenk","Ceren","Ceren Buğlem","Cevahir","Ceyda","Ceyhan","Ceyhun","Ceylan","Cihan","Coşkun","Cömert","Cuma","Cumhur","Cundullah","Cüneyt","Çağdaş","Çağla","Çağlar","Çağrı","Çağrı Serdar","Çavlan","Çetin","Çiğdem","Çile","Damla","Davut","Demet","Demir","Deniz","Deniz Armağan","Deram","Derman","Derviş","Derya",
                "Derya Pınar","Derya Sema","Dicle","Didem","Didem Ayşe","Dilan","Dilara","Dilber","Dilek","Dilşah",
                "Dinçer Aydın","Doğan","Duçem","Duran","Duygu","Ebru","Ebubekir Onur","Ece","Eda","Edip Güvenç","Efruz","Eftal Murat","Egemen","Ekin",
                "Ekrem","Ela","Elçin","Elif","Elif Ayşe","Elif Ceren","Elif Çiler","Elif Nihal","Elif Nur","Elif Tuğçe","Elifcan","Elzem","Emced","Emel","Emel Cennet",
                "Emin","Emin Tonyukuk","Emine","Emine Ayça","Emine Dilek","Emir Kaan","Emir Murat","Emiş","Emrah","Emrah Kemal","Emre","Emre Kağan","Emre Merter","Emrullah","Ender",
                "Enes","Enes Tahir","Engin","Ennur","Enver","Eray","Ercan","Erdal","Erdem","Erdem Can","Erdinç","Erem","Eren",
                "Ergül","Ergün","Erhan","Erhan Hüseyin","Erkan","Erkan Sabri","Erkin","Erol","Ersagun","Ersen","Ersin","Ertan","Ertunç Onur","Esen","Esen İbrahim","Eser","Esin","Esin Seren","Esma","Esma Özlem","Esmeralda","Esra","Esra Can","Esra Nur","Ethem","Evre","Evren","Evrim","Eylem","Eyüp","Eyüp Gökhan","Eyyup Sabri","Eyyüp",
                "Ezel","Ezgi","Ezgi Gizem","Fadıl","Fadime Sevgi","Fahri","Faik","Faris","Faruk","Fatıma İlay","Fatih","Fatih Avni","Fatih Mehmet","Fatih Nazmi","Fatih Rıfat","Fatma","Fatma Begüm",
                "Fatma Betül","Fatma Duygu","Fatma Ece","Fatma Efsun","Fatma Esin","Fatma Esra","Fatma Selcen","Ferat","Feray",
                "Ferda","Ferdi","Ferhan","Ferhat","Feride","Ferit","Fethi","Fethiye","Fevzi Fırat","Fevziye","Feyza","Feyzahan","Feza","Fırat","Fikri","Filiz","Fuat","Fuat Ernis","Fulya","Funda","Funda Özlem","Füsun","Gamze","Gamze Pınar","Ganim","Gizem","Gonca",
                "Gökay","Gökçe","Gökçen","Gökhan","Gökmen","Gökmen Alpaslan","Göknur","Göksel","Göktekin","Gökten","Görkem","Gözde",
                "Gözde Gizem","Gözde Kübra","Gözdem","Güher","Gül","Gülay","Gülbahar","Gülberat","Gülcan","Gülçin","Güldehen",
                "Gülden","Gülden Sinem","Gülen Ece","Gülhanım","Güliz","Güllü Selcen","Gülname","Gülperi","Gülsen","Gülseren",
                "Gülsüm","Gülşah","Gülşen","Gültekin Günhan","Günay","Gündem","Güneş","Gürkan","Habibe","Habil","Habip","Hacer","Hacı",
                "Hacı Hasan","Hacı Kemal","Hacı Mehmet","Hacı Murat","Hacı Ömer","Haci Halil","Hakan","Hale","Halenur","Halil","Halil Can","Halil Cansun","Halil İbrahim","Halilibrahim","Halim","Halime","Halis","Haluk","Hamdi","Hamdiye","Hamit","Hamza",
                "Handan","Hande","Hanım","Hanife Tuğçe","Harun","Hasan","Hasan Bilen","Hasan Cıvan","Hasan Hüseyin","Hasan Kadir","Hasan Sami","Hasan Serkan","Hasan Ulaş","Hasan Yavuzhan","Hasibe","Hasret","Haşim Onur","Hatice","Hatice Eylül","Hatice Nilden","Hatice Özge","Hatike","Hatun","Havva","Hayati","Hayati Can","Hayri","Hayri Üstün","Hayriye","Hayrunnisa",
                "Hazan","Hazel","Hicran","Hidayet","Hidir","Hikmet","Hikmet Ekin","Hilal","Hilayda","Hisar Can","Huriye","Hülya Gözde","Hümeyra",
                "Hüseyin","Hüseyin Cahit","Hüseyin Kalkan","Hüseyin Kunter","Hüseyin Onur","Hüseyin Said","Hüseyin Yavuz","Irazca","Işık","Işık Melike","Işıl",
                "Işın","İbrahim","İbrahim Barış","İbrahim Fuat","İbrahim Halil","İbrahim Tayfun","İdris","İdris Bugra","İhsan","İhsan Burak","İklil","İkram","İlhan","İlkay","İlker","İlknur","İlyas","İnanç","İnci","İpek","İrem","İrfan","İrfan Yıldırım","İsa","İshak","İsmail","İsmail Evren","İsmail Mikdat",
                "İsmail Şenol","İsmail Yavuz","İtibar","İzzet","İzzettin","Jale","Jülide Zehra","Kaan Suat","Kader","Kadir","Kalender","Kamercan",
                "Kamil","Kamuran","Kasım","Kemal","Kemal Kürşat","Kenan","Kenan Ahmet","Kenan Selçuk","Kerim","Kerime Rumeysa","Kezban","Keziban",
                "Kıvanç","Kıymet","Konuralp","Koray","Korhan","Kubilay","Kurtuluş","Kübra","Kürşat","Lale","Latife","Leman","Levent","Leyla","Leziz","Lütfi","Mahir","Mahmut","Mahmut Arda","Mahmut Bakır","Mahmut Burak","Mahmut Emre","Mahmut Esat","Mahmut Nuri","Mahmut Sami","Mahperi","Mahsum","Makbule Seda","Mansur Kürşad","Maria","Maruf","Mazlum","Mediha","Mehmed Uğur","Mehmet","Mehmet Akif","Mehmet Ali","Mehmet Burhan",
                "Mehmet Cihat","Mehmet Deniz","Mehmet Dirim","Mehmet Emrah","Mehmet Evren","Mehmet Fatih","Mehmet Furkan","Mehmet Gökçe","Mehmet Hazbin","Mehmet Hilmi","Mehmet Hüseyin","Mehmet İkbal","Mehmet Koray",
                "Mehmet Murat","Mehmet Nedim","Mehmet Nuri","Mehmet Özer","Mehmet Özgür","Mehmet Raşit","Mehmet Reşit","Mehmet Selahattin",
                "Mehmet Selami","Mehmet Suphi","Mehmet Şirin","Mehmet Vehbi","Mehmet Veysel","Mehmet Yavuz","Mehmet Yıldırım","Mehmet Ziya","Mehri","Mehtap","Melahat","Melda","Melek","Melia","Meliha Esra","Melike","Melike Elif",
                "Meltem","Meltem Hale","Meral","Meral Leman","Meriç","Merih","Mert","Mert Metin","Merve","Merve Nur","Merve Setenay","Meryem","Mesude","Mesut","Metanet Mehrali","Mete","Mete Can","Metin","Mevlüt","Mevsim","Mihrimah Selcen","Mine","Mine Cansu",
                "Miraç","Miray","Muammer","Muammer Hayri","Muammer Müslim","Muhammed","Muhammed Ali","Muhammed Fatih","Muhammed Furkan","Muhammed Hasan","Muhammed Mucahid","Muhammed Nuri","Muhammed Rıza","Muhammed Sami","Muhammed Taha",
                "Muhammed Yusuf","Muhammet Bağbur","Muhammet Devran","Muhammet Fatih","Muhammet Murat","Muhammet Mustafa","Muhammet Tayyip","Muhlis","Muhsin","Mukadder","Mukaddes",
                "Mumun","Murat","Murat Volkan","Musa","Musacide Zehra","Mustafa","Mustafa Abdullah","Mustafa Ali","Mustafa Alican",
                "Mustafa Arif","Mustafa Asım","Mustafa Baran","Mustafa Buğra","Mustafa Cihad","Mustafa Ersagun","Mustafa Ferhat",
                "Mustafa Gürhan","Mustafa Güvenç","Mustafa Kemal","Mustafa Kürşat","Mustafa Nafiz","Mustafa Raşid","Mustafa Turan","Mustafa Ulaş","Mutlu",
                "Muzaffer","Muzaffer Oğuz","Mübeccel","Müberra","Mücadiye","Mücahit","Mücella","Müjdat","Mümtaz","Mümün Fatih","Mümüne",
                "Münever","Mürsel","Mürselin","Mürşit","Müslim","Müşerref","Nafiye","Nafiz","Nagihan","Nail","Naime Sıla","Nalan","Nazan","Nazım","Nazlı","Nazlı Hilal","Nebi","Nebil","Necip","Necmiye Gül","Nefise","Nejdet","Neslihan","Nesrin","Neşe","Neval","Nevin","Nevriye","Nevroz","Nevzat","Nezaket","Nezih","Nezir","Nihal","Nihan","Nihat","Nihat Berkay","Nilay","Nilgün","Nilüfer","Nimet","Nimet Didem","Nizamettin","Nuh","Numan","Nur","Nur Aleyna","Nuran","Nuray","Nurcan","Nurdan","Nurettin","Nurettin İrem","Nurgül","Nurhan","Nuri",
                "Nuri Anıl","Nurmuhammet","Nursel","Nurullah","Oğuz","Oğuz Kaan","Oğuz Kağan","Oğuzhan","Okan","Oktay","Olcay Başak","Onat","Onur","Onur Kadir","Onur Salih","Orçun","Orgül Derya","Orhan","Orhan Uygar","Orkun","Osman","Osman Bilge",
                "Osman Ersegun","Osman Salih","Osman Turgut","Ozan","Ökkeş","Ökkeş Celil","Ökkeş Yılmaz","Ömer","Ömer Aykut",
                "Ömer Faruk","Ömer Gökhan","Ömer Özkan","Ömür","Önder","Önder Turgut","Övgü Anıl","Övünç","Öykü","Özcan","Özden","Özen",
                "Özen Özlem","Özge","Özgül","Özgür","Özgür Sinan","Özhan","Özkan","Özlem","Öznur","Öztan","Papatya","Pelin",
                "Perver","Pervin","Petek","Pınar","Rabia","Rabia Şebnem","Rahime","Rahime Merve","Rahmi Tuna","Ramazan","Ramazan Ferhad","Rasim","Raşan","Raziye",
                "Recep","Recep Gani","Refaettin","Refik","Remziye","Rengin Aslıhan","Resa","Resul","Reşat","Reşit Volkan","Reyhan","Rezan","Rezzan",
                "Rıdvan","Rıfat","Rifat Can","Rukiye","Rukiye Özden","Rumeysa","Rüştü","Saadet",
                "Saadet Nilay","Sabahattin","Sabri Sefa","Said","Salih","Saliha","Saliha Dilek","Saliha Sanem","Salim","Salman","Samet","Samet Sancar","Sami","Sancar","Sanem Gökçen Merve","Sare","Savaş",
                "Seda Elçim","Sedat","Sedef","Sefa","Seher","Seher Özlem","Selahattin","Selami","Selcen",
                "Selkan Murad","Selma","Sema","Sema Nilay","Semih","Semine","Semra","Sena","Senan","Senem","Serap","Seray","Serçin","Serdal","Serdar","Serdar Bora","Serhan","Serhat","Serhat Burkay","Serkan","Serkan Fazlı","Serpil","Sertaç","Servet","Seval",
                "Sevcan","Sevda","Sevde Nur","Sevgi","Sevgül","Sevil","Sevinç","Seyfi","Seyfi Cem","Seyfullah","Seyhan","Sezai",
                "Sezen","Sezer","Sezgi","Sezgin","Sezin","Sıddıka","Sıdıka","Sibel","Sidar","Simender","Simge","Sinan","Sinan Dinçer","Sinem","Sonay","Soner","Songül","Suat","Sultan","Suna","Süheyla","Süheyla Ayça","Süleyman","Süleyman Serdar","Sümeyra","Sümeyye","Süreyya","Süreyya Burcu","Şadi","Şadiye Selin",
                "Şafak","Şahabettin","Şahika","Şahin","Şahinde","Şebnem","Şehmus","Şenay","Şenol","Şerafettin","Şeref Can","Şerif","Şerife","Şükrü","Tahir","Tahsin Batuhan","Talha","Tamer","Taner","Tansu","Tarkan","Tayfun","Tayfur","Taylan","Taylan Uğur","Tayyar Alp","Tekin","Teslime Nazlı","Tevfik","Tevfik Özgün","Tevhid","Teyfik",
                "Timuçin","Timur","Tolga","Tolga Can","Tolgahan","Tolunay","Tuba","Tuba Hanım","Tufan Akın","Tuğba",
                "Tuğberk","Tuğçe","Tuğra","Tuğrul","Tuğsem","Tuna","Tuncay","Turan","Turgay","Turgay Yılmaz","Turğut","Tülay","Tümay",
                "Türker","Ufuk","Uğur","Uğuray","Ulaş","Umut","Umut Can","Umut Seda","Umut Sinan","Ural","Utku","Uygar","Uysan",
                "Übeydullah","Ülkü","Ülkühan","Ümit","Ümmü Gülsüm","Ümmügülsüm","Ümran","Ünal","Ünsal","Üzeyir","Vahdettin Talha",
                "Vasfiye","Vazir Akber","Vedat","Vehbi","Velat","Veli Çağlar","Veli Enes","Velit","Veysel","Veysi","Volkan","Volkan Onur",
                "Yahya","Yakup","Yakup İlker","Yakup Onur","Yalçın","Yasemin","Yaser","Yasin","Yaşar","Yaşar Barbaros","Yaşar Gökhan","Yaşar Gözde","Yavuz","Yavuz Selim","Yelda","Yeliz","Yener","Yetkin","Yıldıray","Yıldırım","Yıldız","Yılmaz","Yiğit","Yiğit Can","Yunus","Yunus Emre",
                "Yurdagül","Yurdun","Yusuf","Yusuf Alper","Yusuf Emre","Yusuf Kenan","Yusuf Ziya","Yüce","Yücel","Yüksel","Yüksel Uğur","Zafer","Zahide","Zarife","Zehra","Zehra Betül","Zekeriya","Zekeriya Ersin","Zeki","Zekiye Seval","Zeliha","Zerin","Zerrin",
                "Zeynalabidin","Zeynep","Zeynep Ezgi","Zeynep Gökçe","Ziya","Zuhal","Zübeyde","Zühal","Zühal Gülsüm","Zühre","Zühtü Bener","Zülfiye","Zümrüt Ela",

 };

            string[] testAppRoles = { "CorporationOwner", "Employee", "SchoolManager", "Student", "SystemAdministrator", "Teacher" };
            string[] testClassroomTypes = { "Bireysel", "Grup", "Fizyoterapi" };
            string[] testEducations = { "Bedensel Engelli Bireyler Destek Eğitim Programı", "Yaygın Gelişimsel Bozukluklar Destek Eğitim Programı", "Zihinsel Engelli Bireyler Destek Eğitim Programı" };
            string[] testEducationBranches = {"Beden Eğitimi","Çocuk Gelişimi ve Bakımı","Çocuk Gelişimi ve Eğit.","Dil ve Konuşma Bozuklukları Uzmanı","Dil ve Konuşma Pataloğu","Dil ve Konuşma Terapisti","Eğitim Odyoloğu",
                "Fizyoterapist","Görme Engelliler Sın.Öğr.","Görsel Sanatlar/Resim","Halkla İlişkiler","İşitme Engelliler Sınıfı Öğretmeni","Odyoloji","Odyoloji ve Konuşma Bozuklukları Uzmanı","Odyometri","Okul Öncesi Öğr.Çoc.Gel.","Okul Öncesi Öğretmenliği",
                "Özel Eğitim Alanı","Özel Eğitim Öğretmenliği","Psikolog","Psikoloji","Rehber Öğretmenliği","Sınıf Öğretmenliği","Sosyoloji","Zihinsel Engelliler Sın.Öğr."
            };
            string[] testJobs = { "Aşçı", "Memur", "Güvenlik Görevlisi", "Halkla İlişkiler", "Hizmetli", "İş Güvenliği Uzmanı", "Sekreter", "Şoför", "Sosyal Hizmet Uzmanı" };

            // ### add Roles ###
            foreach (var item in testAppRoles)
            {
                AppRole data = new AppRole()
                {
                    Name = item
                };
                context.AppRoles.Add(data);
            }

            // ### add ClassroomTypes ###
            foreach (var item in testClassroomTypes)
            {
                ClassroomType data = new ClassroomType()
                {
                    Name = item
                };
                context.ClassroomTypes.Add(data);
            }

            // ### add EducationBranches
            foreach (var item in testEducationBranches)
            {
                EducationBranch data = new EducationBranch()
                {
                    Name = item
                };
                context.EducationBranches.Add(data);
            }

            // ### add Jobs
            foreach (var item in testJobs)
            {
                Job data = new Job()
                {
                    Name = item
                };
                context.Jobs.Add(data);
            }

            context.SaveChanges();

            Guid CorporationOwnerId = context.AppRoles.FirstOrDefault(x => x.Name == "CorporationOwner").Id;
            Guid EmployeeId = context.AppRoles.FirstOrDefault(x => x.Name == "Employee").Id;
            Guid SchoolManagerId = context.AppRoles.FirstOrDefault(x => x.Name == "SchoolManager").Id;
            Guid StudentId = context.AppRoles.FirstOrDefault(x => x.Name == "Student").Id;
            Guid SystemAdministratorId = context.AppRoles.FirstOrDefault(x => x.Name == "SystemAdministrator").Id;
            Guid TeacherId = context.AppRoles.FirstOrDefault(x => x.Name == "Teacher").Id;



            // ### add SystemAdministrators ###
            AppUser au1 = new AppUser()
            {
                UserName = "yonetici1",
                Password = "123456",
                Email = "yonetici1@oeybs.com",
                IsActive = true
            };
            AppUser au2 = new AppUser()
            {
                UserName = "yonetici2",
                Password = "123456",
                Email = "yonetici2@oeybs.com",
                IsActive = true
            };

            context.AppUsers.Add(au1);
            context.AppUsers.Add(au2);

            context.SaveChanges();

            SystemAdministrator admin1 = new SystemAdministrator()
            {
                Id = context.AppUsers.FirstOrDefault(x => x.UserName == au1.UserName).Id,
                FirstName = "ALİ",
                LastName = "TEKİN"
            };
            SystemAdministrator admin2 = new SystemAdministrator()
            {
                Id = context.AppUsers.FirstOrDefault(x => x.UserName == au2.UserName).Id,
                FirstName = "EMRE",
                LastName = "GÖKTÜRK"
            };

            context.SystemAdministrators.Add(admin1);
            context.SystemAdministrators.Add(admin2);

            context.SaveChanges();

            UserRole ur1 = new UserRole()
            {
                AppRoleId = SystemAdministratorId,
                AppUserId = context.AppUsers.FirstOrDefault(x => x.UserName == au1.UserName).Id
            };
            UserRole ur2 = new UserRole()
            {
                AppRoleId = SystemAdministratorId,
                AppUserId = context.AppUsers.FirstOrDefault(x => x.UserName == au2.UserName).Id
            };

            context.UserRole.Add(ur1);
            context.UserRole.Add(ur2);

            context.SaveChanges();

            // add CorporationOwners
            AppUser cau1 = new AppUser()
            {
                UserName = "abcyonetici",
                Password = "123456",
                Email = "abcyonetici@oeybs.com",
                IsActive = true
            };
            AppUser cau2 = new AppUser()
            {
                UserName = "defyonetici",
                Password = "123456",
                Email = "defyonetici@oeybs.com",
                IsActive = true
            };
            AppUser cau3 = new AppUser()
            {
                UserName = "ghiyonetici",
                Password = "123456",
                Email = "ghiyonetici@oeybs.com",
                IsActive = true
            };

            context.AppUsers.Add(cau1);
            context.AppUsers.Add(cau2);
            context.AppUsers.Add(cau3);

            context.SaveChanges();

            CorporationOwner co1 = new CorporationOwner()
            {
                FirstName = FirstNameList[FakeData.NumberData.GetNumber(1, FirstNameList.Length - 2)].ToUpper(),
                LastName = LastNameList[FakeData.NumberData.GetNumber(1, LastNameList.Length - 2)].ToUpper(),
                IdentificationNumber = (FakeData.NumberData.GetNumber(10000, 99999) + "" + FakeData.NumberData.GetNumber(100000, 999999)).ToString(),
                Id = context.AppUsers.FirstOrDefault(x => x.UserName == cau1.UserName).Id
            };
            CorporationOwner co2 = new CorporationOwner()
            {
                FirstName = FirstNameList[FakeData.NumberData.GetNumber(1, FirstNameList.Length - 2)].ToUpper(),
                LastName = LastNameList[FakeData.NumberData.GetNumber(1, LastNameList.Length - 2)].ToUpper(),
                IdentificationNumber = (FakeData.NumberData.GetNumber(10000, 99999) + "" + FakeData.NumberData.GetNumber(100000, 999999)).ToString(),
                Id = context.AppUsers.FirstOrDefault(x => x.UserName == cau2.UserName).Id
            };
            CorporationOwner co3 = new CorporationOwner()
            {
                FirstName = FirstNameList[FakeData.NumberData.GetNumber(1, FirstNameList.Length - 2)].ToUpper(),
                LastName = LastNameList[FakeData.NumberData.GetNumber(1, LastNameList.Length - 2)].ToUpper(),
                IdentificationNumber = (FakeData.NumberData.GetNumber(10000, 99999) + "" + FakeData.NumberData.GetNumber(100000, 999999)).ToString(),
                Id = context.AppUsers.FirstOrDefault(x => x.UserName == cau3.UserName).Id
            };

            context.CorporationOwners.Add(co1);
            context.CorporationOwners.Add(co2);
            context.CorporationOwners.Add(co3);

            context.SaveChanges();

            UserRole cour1 = new UserRole()
            {
                AppRoleId = CorporationOwnerId,
                AppUserId = context.AppUsers.FirstOrDefault(x => x.UserName == cau1.UserName).Id
            };
            UserRole cour2 = new UserRole()
            {
                AppRoleId = CorporationOwnerId,
                AppUserId = context.AppUsers.FirstOrDefault(x => x.UserName == cau2.UserName).Id
            };
            UserRole cour3 = new UserRole()
            {
                AppRoleId = CorporationOwnerId,
                AppUserId = context.AppUsers.FirstOrDefault(x => x.UserName == cau3.UserName).Id
            };

            context.UserRole.Add(cour1);
            context.UserRole.Add(cour2);
            context.UserRole.Add(cour3);

            context.SaveChanges();

            // ### add Corporations ###
            Corporation corporation1 = new Corporation()
            {
                Name = "ABC Özel Eğitim Ve Rehabilitasyon Merkezi",
                Code = "ABC057",
                StartOfContractDate = now,
                EndOfContractDate = now.AddYears(2),
                IsActive = true,
                CreatedOn = now,
                Location = FakeData.PlaceData.GetPostCode(),
                TaxNumber = FakeData.TextData.GetNumeric(14),
                DepartmentofTaxation = "İstanbul Kadıköy Vergi Dairesi",
                CorporationOwnerId = context.AppUsers.FirstOrDefault(x => x.UserName == cau1.UserName).Id
            };
            Corporation corporation2 = new Corporation()
            {
                Name = "DEF Özel Eğitim Ve Rehabilitasyon Merkezi",
                Code = "DEF752",
                StartOfContractDate = now.AddDays(-1),
                EndOfContractDate = now.AddYears(3),
                IsActive = true,
                CreatedOn = now.AddDays(-1),
                Location = FakeData.PlaceData.GetPostCode(),
                TaxNumber = FakeData.TextData.GetNumeric(14),
                DepartmentofTaxation = "İstanbul Beyoğlu Vergi Dairesi",
                CorporationOwnerId = context.AppUsers.FirstOrDefault(x => x.UserName == cau2.UserName).Id
            };
            Corporation corporation3 = new Corporation()
            {
                Name = "GHİ Özel Eğitim Ve Rehabilitasyon Merkezi",
                Code = "GHI379",
                StartOfContractDate = now.AddDays(-2),
                EndOfContractDate = now.AddYears(1),
                IsActive = true,
                CreatedOn = now.AddDays(-2),
                Location = FakeData.PlaceData.GetPostCode(),
                TaxNumber = FakeData.TextData.GetNumeric(14),
                DepartmentofTaxation = "İstanbul Fatih Vergi Dairesi",
                CorporationOwnerId = context.AppUsers.FirstOrDefault(x => x.UserName == cau3.UserName).Id
            };

            context.Corporations.Add(corporation1);
            context.Corporations.Add(corporation2);
            context.Corporations.Add(corporation3);

            context.SaveChanges();

            Guid Corporation1Id = context.Corporations.FirstOrDefault(x => x.Code == corporation1.Code).Id;
            Guid Corporation2Id = context.Corporations.FirstOrDefault(x => x.Code == corporation2.Code).Id;
            Guid Corporation3Id = context.Corporations.FirstOrDefault(x => x.Code == corporation3.Code).Id;

            // ### add CorporationAddresses ###
            CorporationAddress ca1 = new CorporationAddress()
            {
                Title = "Merkez Şube",
                City = "İstanbul",
                District = "Kadıköy",
                PostCode = "34734",
                Line = "Hasanpaşa Mahallesi, Taşlık Caddesi, No:47",
                PhoneNumber = "(0216) 123 45 67",
                PhoneNumber2 = "(0532) 123 45 67",
                CorporationId = Corporation1Id
            };
            CorporationAddress ca2 = new CorporationAddress()
            {
                Title = "Merkez Şube",
                City = "İstanbul",
                District = "Beyoğlu",
                PostCode = "34740",
                Line = "Kaptanpaşa Mahallesi, Cumhuriyet Caddesi, No:12",
                PhoneNumber = "(0216) 123 45 67",
                PhoneNumber2 = "(0532) 123 45 67",
                CorporationId = Corporation2Id
            };
            CorporationAddress ca3 = new CorporationAddress()
            {
                Title = "Merkez Şube",
                City = "İstanbul",
                District = "Fatih",
                PostCode = "34093",
                Line = "Akşemsettin Mahallesi, Akdeniz Caddesi, No:30",
                PhoneNumber = "(0216) 123 45 67",
                PhoneNumber2 = "(0532) 123 45 67",
                CorporationId = Corporation3Id
            };

            context.CorporationAddresses.Add(ca1);
            context.CorporationAddresses.Add(ca2);
            context.CorporationAddresses.Add(ca3);

            context.SaveChanges();

            // ### add Educations ###
            foreach (var item in testEducations)
            {
                Education ed1 = new Education()
                {
                    Name = item,
                    Total = FakeData.NumberData.GetNumber(8, 20),
                    CorporationId = Corporation1Id,
                    Description = "Test verisidir."

                };
                Education ed2 = new Education()
                {
                    Name = item,
                    Total = FakeData.NumberData.GetNumber(8, 20),
                    CorporationId = Corporation2Id,
                    Description = "Test verisidir."

                };
                Education ed3 = new Education()
                {
                    Name = item,
                    Total = FakeData.NumberData.GetNumber(8, 20),
                    CorporationId = Corporation3Id,
                    Description = "Test verisidir."

                };

                context.Educations.Add(ed1);
                context.Educations.Add(ed2);
                context.Educations.Add(ed3);
            }

            context.SaveChanges();

            // ### add Calassrooms ###
            int ClassroomTyp1Id = context.ClassroomTypes.FirstOrDefault(x => x.Name == "Bireysel").Id;
            int ClassroomTyp2Id = context.ClassroomTypes.FirstOrDefault(x => x.Name == "Grup").Id;
            int ClassroomTyp3Id = context.ClassroomTypes.FirstOrDefault(x => x.Name == "Fizyoterapi").Id;

            //  Corporation1 Classrooms
            for (int i = 1; i < FakeData.NumberData.GetNumber(3, 6); i++)
            {
                Classroom classroom = new Classroom()
                {
                    ClassroomTypeId = ClassroomTyp1Id,
                    CorporationId = Corporation1Id,
                    Name = $"Yaygın Gelişimsel Bozukluklar Bireysel Eğitim Odası {i}",
                    Total = FakeData.NumberData.GetNumber(2, 10),
                    Description = "Test verisidir."
                };
                context.Classrooms.Add(classroom);
            }
            for (int i = 1; i < FakeData.NumberData.GetNumber(4, 8); i++)
            {
                Classroom classroom2 = new Classroom()
                {
                    ClassroomTypeId = ClassroomTyp2Id,
                    CorporationId = Corporation1Id,
                    Name = $"Yaygın Gelişimsel Bozukluklar Grup Eğitim Odası {i}",
                    Total = FakeData.NumberData.GetNumber(5, 20),
                    Description = "Test verisidir."
                };
                context.Classrooms.Add(classroom2);
            }
            for (int i = 1; i < FakeData.NumberData.GetNumber(2, 5); i++)
            {
                Classroom classroom3 = new Classroom()
                {
                    ClassroomTypeId = ClassroomTyp3Id,
                    CorporationId = Corporation1Id,
                    Name = $"Fizyoterapi Odası {i}",
                    Total = FakeData.NumberData.GetNumber(5, 20),
                    Description = "Test verisidir."
                };
                context.Classrooms.Add(classroom3);
            }

            context.SaveChanges();

            //  Corporation2 Classrooms
            for (int i = 1; i < FakeData.NumberData.GetNumber(3, 6); i++)
            {
                Classroom classroom = new Classroom()
                {
                    ClassroomTypeId = ClassroomTyp1Id,
                    CorporationId = Corporation2Id,
                    Name = $"Yaygın Gelişimsel Bozukluklar Bireysel Eğitim Odası {i}",
                    Total = FakeData.NumberData.GetNumber(2, 10),
                    Description = "Test verisidir."
                };
                context.Classrooms.Add(classroom);
            }
            for (int i = 1; i < FakeData.NumberData.GetNumber(4, 8); i++)
            {
                Classroom classroom2 = new Classroom()
                {
                    ClassroomTypeId = ClassroomTyp2Id,
                    CorporationId = Corporation2Id,
                    Name = $"Yaygın Gelişimsel Bozukluklar Grup Eğitim Odası {i}",
                    Total = FakeData.NumberData.GetNumber(5, 20),
                    Description = "Test verisidir."
                };
                context.Classrooms.Add(classroom2);
            }
            for (int i = 1; i < FakeData.NumberData.GetNumber(2, 5); i++)
            {
                Classroom classroom3 = new Classroom()
                {
                    ClassroomTypeId = ClassroomTyp3Id,
                    CorporationId = Corporation2Id,
                    Name = $"Fizyoterapi Odası {i}",
                    Total = FakeData.NumberData.GetNumber(2, 10),
                    Description = "Test verisidir."
                };
                context.Classrooms.Add(classroom3);
            }

            context.SaveChanges();

            //  Corporation2 Classrooms
            for (int i = 1; i < FakeData.NumberData.GetNumber(3, 6); i++)
            {
                Classroom classroom = new Classroom()
                {
                    ClassroomTypeId = ClassroomTyp1Id,
                    CorporationId = Corporation3Id,
                    Name = $"Yaygın Gelişimsel Bozukluklar Bireysel Eğitim Odası {i}",
                    Total = FakeData.NumberData.GetNumber(2, 10),
                    Description = "Test verisidir."
                };
                context.Classrooms.Add(classroom);
            }
            for (int i = 1; i < FakeData.NumberData.GetNumber(4, 8); i++)
            {
                Classroom classroom2 = new Classroom()
                {
                    ClassroomTypeId = ClassroomTyp2Id,
                    CorporationId = Corporation3Id,
                    Name = $"Yaygın Gelişimsel Bozukluklar Grup Eğitim Odası {i}",
                    Total = FakeData.NumberData.GetNumber(5, 20),
                    Description = "Test verisidir."
                };
                context.Classrooms.Add(classroom2);
            }
            for (int i = 1; i < FakeData.NumberData.GetNumber(2, 5); i++)
            {
                Classroom classroom3 = new Classroom()
                {
                    ClassroomTypeId = ClassroomTyp3Id,
                    CorporationId = Corporation3Id,
                    Name = $"Fizyoterapi Odası {i}",
                    Total = FakeData.NumberData.GetNumber(2, 10),
                    Description = "Test verisidir."
                };
                context.Classrooms.Add(classroom3);
            }

            context.SaveChanges();

            // ### add SchoolManagerS ###
            AppUser smau1 = new AppUser()
            {
                UserName = "abcmudur",
                Password = "123456",
                Email = "abcmudur@oeybs.com",
                IsActive = true
            };
            AppUser smau2 = new AppUser()
            {
                UserName = "abcmuduryardimcisi",
                Password = "123456",
                Email = "abcmuduryardimcisi@oeybs.com",
                IsActive = true
            };
            AppUser smau3 = new AppUser()
            {
                UserName = "defmudur",
                Password = "123456",
                Email = "defmudur@oeybs.com",
                IsActive = true
            };
            AppUser smau4 = new AppUser()
            {
                UserName = "defmuduryardimcisi",
                Password = "123456",
                Email = "defmuduryardimcisi@oeybs.com",
                IsActive = true
            };
            AppUser smau5 = new AppUser()
            {
                UserName = "ghimudur",
                Password = "123456",
                Email = "ghimudur@oeybs.com",
                IsActive = true
            };
            AppUser smau6 = new AppUser()
            {
                UserName = "ghimuduryardimcisi",
                Password = "123456",
                Email = "ghimuduryardimcisi@oeybs.com",
                IsActive = true
            };

            context.AppUsers.Add(smau1);
            context.AppUsers.Add(smau2);
            context.AppUsers.Add(smau3);
            context.AppUsers.Add(smau4);
            context.AppUsers.Add(smau5);
            context.AppUsers.Add(smau6);

            context.SaveChanges();

            SchoolManager sm1 = new SchoolManager()
            {
                FirstName = FirstNameList[FakeData.NumberData.GetNumber(1, FirstNameList.Length - 2)].ToUpper(),
                LastName = LastNameList[FakeData.NumberData.GetNumber(1, LastNameList.Length - 2)].ToUpper(),
                Id = context.AppUsers.FirstOrDefault(x => x.UserName == smau1.UserName).Id
            };
            SchoolManager sm2 = new SchoolManager()
            {
                FirstName = FirstNameList[FakeData.NumberData.GetNumber(1, FirstNameList.Length - 2)].ToUpper(),
                LastName = LastNameList[FakeData.NumberData.GetNumber(1, LastNameList.Length - 2)].ToUpper(),
                Id = context.AppUsers.FirstOrDefault(x => x.UserName == smau2.UserName).Id
            };
            SchoolManager sm3 = new SchoolManager()
            {
                FirstName = FirstNameList[FakeData.NumberData.GetNumber(1, FirstNameList.Length - 2)].ToUpper(),
                LastName = LastNameList[FakeData.NumberData.GetNumber(1, LastNameList.Length - 2)].ToUpper(),
                Id = context.AppUsers.FirstOrDefault(x => x.UserName == smau3.UserName).Id
            };
            SchoolManager sm4 = new SchoolManager()
            {
                FirstName = FirstNameList[FakeData.NumberData.GetNumber(1, FirstNameList.Length - 2)].ToUpper(),
                LastName = LastNameList[FakeData.NumberData.GetNumber(1, LastNameList.Length - 2)].ToUpper(),
                Id = context.AppUsers.FirstOrDefault(x => x.UserName == smau4.UserName).Id
            };
            SchoolManager sm5 = new SchoolManager()
            {
                FirstName = FirstNameList[FakeData.NumberData.GetNumber(1, FirstNameList.Length - 2)].ToUpper(),
                LastName = LastNameList[FakeData.NumberData.GetNumber(1, LastNameList.Length - 2)].ToUpper(),
                Id = context.AppUsers.FirstOrDefault(x => x.UserName == smau5.UserName).Id
            };
            SchoolManager sm6 = new SchoolManager()
            {
                FirstName = FirstNameList[FakeData.NumberData.GetNumber(1, FirstNameList.Length - 2)].ToUpper(),
                LastName = LastNameList[FakeData.NumberData.GetNumber(1, LastNameList.Length - 2)].ToUpper(),
                Id = context.AppUsers.FirstOrDefault(x => x.UserName == smau6.UserName).Id
            };

            context.SchoolManagers.Add(sm1);
            context.SchoolManagers.Add(sm2);
            context.SchoolManagers.Add(sm3);
            context.SchoolManagers.Add(sm4);
            context.SchoolManagers.Add(sm5);
            context.SchoolManagers.Add(sm6);

            context.SaveChanges();

            UserRole smur1 = new UserRole()
            {
                AppRoleId = SchoolManagerId,
                AppUserId = context.AppUsers.FirstOrDefault(x => x.UserName == smau1.UserName).Id
            };
            UserRole smur2 = new UserRole()
            {
                AppRoleId = SchoolManagerId,
                AppUserId = context.AppUsers.FirstOrDefault(x => x.UserName == smau2.UserName).Id
            };
            UserRole smur3 = new UserRole()
            {
                AppRoleId = SchoolManagerId,
                AppUserId = context.AppUsers.FirstOrDefault(x => x.UserName == smau3.UserName).Id
            };
            UserRole smur4 = new UserRole()
            {
                AppRoleId = SchoolManagerId,
                AppUserId = context.AppUsers.FirstOrDefault(x => x.UserName == smau4.UserName).Id
            };
            UserRole smur5 = new UserRole()
            {
                AppRoleId = SchoolManagerId,
                AppUserId = context.AppUsers.FirstOrDefault(x => x.UserName == smau5.UserName).Id
            };
            UserRole smur6 = new UserRole()
            {
                AppRoleId = SchoolManagerId,
                AppUserId = context.AppUsers.FirstOrDefault(x => x.UserName == smau6.UserName).Id
            };

            context.UserRole.Add(smur1);
            context.UserRole.Add(smur2);
            context.UserRole.Add(smur3);
            context.UserRole.Add(smur4);
            context.UserRole.Add(smur5);
            context.UserRole.Add(smur6);

            context.SaveChanges();

            // ### add CorporationSchoolManagers ###
            CorporationSchoolManager csm1 = new CorporationSchoolManager()
            {
                CorporationId = Corporation1Id,
                SchoolManagerId = context.AppUsers.FirstOrDefault(x => x.UserName == smau1.UserName).Id
            };
            CorporationSchoolManager csm2 = new CorporationSchoolManager()
            {
                CorporationId = Corporation1Id,
                SchoolManagerId = context.AppUsers.FirstOrDefault(x => x.UserName == smau2.UserName).Id
            };
            CorporationSchoolManager csm3 = new CorporationSchoolManager()
            {
                CorporationId = Corporation2Id,
                SchoolManagerId = context.AppUsers.FirstOrDefault(x => x.UserName == smau3.UserName).Id
            };
            CorporationSchoolManager csm4 = new CorporationSchoolManager()
            {
                CorporationId = Corporation2Id,
                SchoolManagerId = context.AppUsers.FirstOrDefault(x => x.UserName == smau4.UserName).Id
            };
            CorporationSchoolManager csm5 = new CorporationSchoolManager()
            {
                CorporationId = Corporation3Id,
                SchoolManagerId = context.AppUsers.FirstOrDefault(x => x.UserName == smau5.UserName).Id
            };
            CorporationSchoolManager csm6 = new CorporationSchoolManager()
            {
                CorporationId = Corporation3Id,
                SchoolManagerId = context.AppUsers.FirstOrDefault(x => x.UserName == smau6.UserName).Id
            };

            context.CorporationSchoolManagers.Add(csm1);
            context.CorporationSchoolManagers.Add(csm2);
            context.CorporationSchoolManagers.Add(csm3);
            context.CorporationSchoolManagers.Add(csm4);
            context.CorporationSchoolManagers.Add(csm5);
            context.CorporationSchoolManagers.Add(csm6);

            context.SaveChanges();

            // ### add Employes ###
                    

            // Corporation1 Employees
            List<string> testCorporation1Personel = new List<string>();

            for (int i = 1; i <= 10; i++)
            {
                testCorporation1Personel.Add($"abcpersonel{i}");
                AppUser c1au = new AppUser()
                {
                    UserName = $"abcpersonel{i}",
                    Password = "123456",
                    Email = $"abcpersonel{i}@oeybs.com",
                    IsActive = true

                };
                context.AppUsers.Add(c1au);
            }
            context.SaveChanges();

            foreach (var item in testCorporation1Personel)
            {
                Employee employee = new Employee()
                {
                    FirstName = FirstNameList[FakeData.NumberData.GetNumber(1, FirstNameList.Length - 2)].ToUpper(),
                    LastName = LastNameList[FakeData.NumberData.GetNumber(1, LastNameList.Length - 2)].ToUpper(),
                    Id = context.AppUsers.FirstOrDefault(x => x.UserName == item).Id
                };
                context.Employees.Add(employee);
            }
            context.SaveChanges();

            foreach (var item in testCorporation1Personel)
            {
                UserRole c1ur = new UserRole()
                {
                    AppRoleId = EmployeeId,
                    AppUserId = context.AppUsers.FirstOrDefault(x => x.UserName == item).Id
                };
                context.UserRole.Add(c1ur);
            }
            context.SaveChanges();

            foreach (var item in testCorporation1Personel)
            {
                int k = FakeData.NumberData.GetNumber(3, 10);
                EmployeeJob c1ej = new EmployeeJob()
                {
                    EmployeeId = context.AppUsers.FirstOrDefault(x => x.UserName == item).Id,
                    JobId = k % 2 == 0 ? context.Jobs.FirstOrDefault(x=>x.Name== "Şoför").Id : context.Jobs.FirstOrDefault(x => x.Name == "Sekreter").Id
                };
                context.EmployeeJobs.Add(c1ej);
            }
            context.SaveChanges();

            foreach (var item in testCorporation1Personel)
            {
                CorporationEmployee c1ce = new CorporationEmployee()
                {
                    CorporationId = Corporation1Id,
                    EmployeeId = context.AppUsers.FirstOrDefault(x => x.UserName == item).Id
                };
                context.CorporationEmployees.Add(c1ce);
            }
            context.SaveChanges();


            // Corporation2 Employees
            List<string> testCorporation2Personel = new List<string>();

            for (int i = 1; i <= 8; i++)
            {
                testCorporation2Personel.Add($"defpersonel{i}");
                AppUser c2au = new AppUser()
                {
                    UserName = $"defpersonel{i}",
                    Password = "123456",
                    Email = $"defpersonel{i}@oeybs.com",
                    IsActive = true

                };
                context.AppUsers.Add(c2au);
            }
            context.SaveChanges();

            foreach (var item in testCorporation2Personel)
            {
                Employee employee = new Employee()
                {
                    FirstName = FirstNameList[FakeData.NumberData.GetNumber(1, FirstNameList.Length - 2)].ToUpper(),
                    LastName = LastNameList[FakeData.NumberData.GetNumber(1, LastNameList.Length - 2)].ToUpper(),
                    Id = context.AppUsers.FirstOrDefault(x => x.UserName == item).Id
                };
                context.Employees.Add(employee);
            }
            context.SaveChanges();

            foreach (var item in testCorporation2Personel)
            {
                UserRole c2ur = new UserRole()
                {
                    AppRoleId = EmployeeId,
                    AppUserId = context.AppUsers.FirstOrDefault(x => x.UserName == item).Id
                };
                context.UserRole.Add(c2ur);
            }
            context.SaveChanges();

            foreach (var item in testCorporation2Personel)
            {
                int k = FakeData.NumberData.GetNumber(3, 10);
                EmployeeJob c2ej = new EmployeeJob()
                {
                    EmployeeId = context.AppUsers.FirstOrDefault(x => x.UserName == item).Id,
                    JobId = k % 2 == 0 ? context.Jobs.FirstOrDefault(x => x.Name == "Şoför").Id : context.Jobs.FirstOrDefault(x => x.Name == "Sekreter").Id
                };
                context.EmployeeJobs.Add(c2ej);
            }
            context.SaveChanges();

            foreach (var item in testCorporation2Personel)
            {
                CorporationEmployee c2ce = new CorporationEmployee()
                {
                    CorporationId = Corporation2Id,
                    EmployeeId = context.AppUsers.FirstOrDefault(x => x.UserName == item).Id
                };
                context.CorporationEmployees.Add(c2ce);
            }
            context.SaveChanges();


            // Corporation3 Employees
            List<string> testCorporation3Personel = new List<string>();

            for (int i = 1; i <= 11; i++)
            {
                testCorporation3Personel.Add($"ghipersonel{i}");
                AppUser c3au = new AppUser()
                {
                    UserName = $"ghipersonel{i}",
                    Password = "123456",
                    Email = $"ghipersonel{i}@oeybs.com",
                    IsActive = true

                };
                context.AppUsers.Add(c3au);
            }
            context.SaveChanges();

            foreach (var item in testCorporation3Personel)
            {
                Employee employee = new Employee()
                {
                    FirstName = FirstNameList[FakeData.NumberData.GetNumber(1, FirstNameList.Length - 2)].ToUpper(),
                    LastName = LastNameList[FakeData.NumberData.GetNumber(1, LastNameList.Length - 2)].ToUpper(),
                    Id = context.AppUsers.FirstOrDefault(x => x.UserName == item).Id
                };
                context.Employees.Add(employee);
            }
            context.SaveChanges();

            foreach (var item in testCorporation3Personel)
            {
                UserRole c3ur = new UserRole()
                {
                    AppRoleId = EmployeeId,
                    AppUserId = context.AppUsers.FirstOrDefault(x => x.UserName == item).Id
                };
                context.UserRole.Add(c3ur);
            }
            context.SaveChanges();

            foreach (var item in testCorporation3Personel)
            {
                int k = FakeData.NumberData.GetNumber(3, 10);
                EmployeeJob c3ej = new EmployeeJob()
                {
                    EmployeeId = context.AppUsers.FirstOrDefault(x => x.UserName == item).Id,
                    JobId = k % 2 == 0 ? context.Jobs.FirstOrDefault(x => x.Name == "Şoför").Id : context.Jobs.FirstOrDefault(x => x.Name == "Hizmetli").Id
                };
                context.EmployeeJobs.Add(c3ej);
            }
            context.SaveChanges();

            foreach (var item in testCorporation3Personel)
            {
                CorporationEmployee c3ce = new CorporationEmployee()
                {
                    CorporationId = Corporation3Id,
                    EmployeeId = context.AppUsers.FirstOrDefault(x => x.UserName == item).Id
                };
                context.CorporationEmployees.Add(c3ce);
            }
            context.SaveChanges();

            // ### add Teachers ###
            List<string> testTeacherList = new List<string>();

            for (int i = 1; i < 21; i++)
            {
                testTeacherList.Add($"ogretmen{i}");
                AppUser tau = new AppUser()
                {
                    UserName = $"ogretmen{i}",
                    Password = "123456",
                    Email = $"ogretmen{i}@oeybs.com",
                    IsActive = true
                };
                context.AppUsers.Add(tau);
            }
            context.SaveChanges();

            foreach (var item in testTeacherList)
            {
                Teacher teacher = new Teacher()
                {
                    FirstName = FirstNameList[FakeData.NumberData.GetNumber(1, FirstNameList.Length - 2)].ToUpper(),
                    LastName = LastNameList[FakeData.NumberData.GetNumber(1, LastNameList.Length - 2)].ToUpper(),
                    Id = context.AppUsers.FirstOrDefault(x => x.UserName == item).Id
                };
                context.Teachers.Add(teacher);
            }
            context.SaveChanges();


            foreach (var item in testTeacherList)
            {
                UserRole tur = new UserRole()
                {
                    AppRoleId = TeacherId,
                    AppUserId = context.AppUsers.FirstOrDefault(x => x.UserName == item).Id
                };
                context.UserRole.Add(tur);
            }
            context.SaveChanges();

            // ### add TeacherFields ###
            var userRoles = context.UserRole.ToList();
            var teacherList = userRoles.Where(x => x.AppRoleId == TeacherId).ToList();
            List<Guid> db_TeacherListId = teacherList.Select(x => x.AppUserId).ToList();

            var db_EducationBranches = context.EducationBranches.ToList();

            foreach (var item in db_TeacherListId)
            {
                int k = FakeData.NumberData.GetNumber(1, db_EducationBranches.Count - 4);
                for (int i = 0; i < FakeData.NumberData.GetNumber(1, 3); i++)
                {
                    TeacherField tf = new TeacherField()
                    {
                        TeacherId = item,
                        EducationBranchId = db_EducationBranches[k].Id
                    };
                    context.TeacherFields.Add(tf);
                    k++;
                }
            }
            context.SaveChanges();

            // ### add CorporationTeachers ###
            foreach (var item in db_TeacherListId)
            {
                int k = FakeData.NumberData.GetNumber(1, 4);
                Guid corporationId = Corporation3Id;

                switch (k)
                {
                    case 1:
                        corporationId = Corporation1Id;
                        break;
                    case 2:
                        corporationId = Corporation2Id;
                        break;
                    case 3:
                        corporationId = Corporation3Id;
                        break;
                    default:
                        corporationId = Corporation1Id;
                        break;
                }


                CorporationTeacher corporationTeacher = new CorporationTeacher()
                {
                    TeacherId = item,
                    CorporationId = corporationId
                };
                context.CorporationTeachers.Add(corporationTeacher);


            }
            context.SaveChanges();

            // ### add Student ###
            List<string> testStudentList = new List<string>();
            for (int i = 1; i < 51; i++)
            {
                testStudentList.Add($"ogrenci{i}");

                AppUser stau = new AppUser()
                {
                    UserName = $"ogrenci{i}",
                    Password = "123456",
                    Email = $"ogrenci{i}@oeybs.com",
                    IsActive = true
                };
                context.AppUsers.Add(stau);
            }
            context.SaveChanges();

            foreach (var item in testStudentList)
            {
                string rParentsName = FirstNameList[FakeData.NumberData.GetNumber(1, FirstNameList.Length - 2)].ToUpper();
                string rLastName = LastNameList[FakeData.NumberData.GetNumber(1, LastNameList.Length - 2)].ToUpper();
                int k = FakeData.NumberData.GetNumber(1, 15);

                Student st = new Student()
                {
                    FirstName = FirstNameList[FakeData.NumberData.GetNumber(1, FirstNameList.Length - 2)].ToUpper(),
                    LastName = rLastName,
                    IdentificationNumber = FakeData.TextData.GetNumeric(11),
                    FathersName = FirstNameList[FakeData.NumberData.GetNumber(1, FirstNameList.Length - 2)].ToUpper(),
                    Gender = k % 2 == 0 ? "Erkek" : "Kadın",
                    BirthDay = FakeData.DateTimeData.GetDatetime(now.AddYears(-20), now.AddYears(-7)),
                    ParentsFullName = rParentsName + " " + rLastName,
                    ParentsIdentificationNumber = FakeData.TextData.GetNumeric(11),
                    SchoolStatus = k % 3 == 0 ? "Sabahçı" : "Tam Gün",
                    PayStatus = k % 5 == 0 ? "Ücretli(MEB)" : "Ücretsiz(MEB)",
                    ServiceStatus = k % 7 == 0 ? "Var" : "Yok",
                    Id = context.AppUsers.FirstOrDefault(x => x.UserName == item).Id

                };
                context.Students.Add(st);
            }
            context.SaveChanges();

            foreach (var item in testStudentList)
            {
                UserRole tur = new UserRole()
                {
                    AppRoleId = StudentId,
                    AppUserId = context.AppUsers.FirstOrDefault(x => x.UserName == item).Id
                };
                context.UserRole.Add(tur);
            }
            context.SaveChanges();

            // ### add CorporationStudents ###
            var userRolesStd = context.UserRole.ToList();
            var studentList = userRolesStd.Where(x => x.AppRoleId == StudentId).ToList();
            List<Guid> db_StudentListId = studentList.Select(x => x.AppUserId).ToList();

            foreach (var item in db_StudentListId)
            {
                int k = FakeData.NumberData.GetNumber(1, 4);
                Guid corporationId = Corporation1Id;

                switch (k)
                {
                    case 1:
                        corporationId = Corporation1Id;
                        break;
                    case 2:
                        corporationId = Corporation2Id;
                        break;
                    case 3:
                        corporationId = Corporation3Id;
                        break;
                    default:
                        corporationId = Corporation1Id;
                        break;
                }


                CorporationStudent corporationStudent = new CorporationStudent()
                {
                    StudentId = item,
                    CorporationId = corporationId
                };
                context.CorporationStudents.Add(corporationStudent);
            }
            context.SaveChanges();


        }




    }
}
