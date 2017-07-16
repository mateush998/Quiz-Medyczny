using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pytania_quiz
{
    public class Pytania
    {
        public int numAnswer = 0;
        public int numQuestion = 0;
        public string textQuestion;
        public string textAnswer1;
        public string textAnswer2;
        public string textAnswer3;
        public string textAnswer4;

        public Pytania()
        {
            numAnswer = 0;
            numQuestion = 0;
            textAnswer1 = "";
            textAnswer2 = "";
            textAnswer3 = "";
            textAnswer4 = "";
            textQuestion = "";
        }

        public void GiveMeQuestion(int numQuestion)
        {
            switch(numQuestion)
            {
                case 1:                  
                    textQuestion = "Ile trwa przewlekła biegunka?";
                    textAnswer1 = "około 3 dni";
                    textAnswer2 = "około jednego miesiąca";
                    textAnswer3 = "maksymalnie jeden tydzień";
                    textAnswer4 = "po wyżej dwóch tygodni";
                    numAnswer = 4;
                    break;
                case 2:
                    textQuestion = "Odwodnienie u dziecka (ile %) to odwodnienie lekkie?";
                    textAnswer1 = "utrata płynu nie przekracza 5% wyjściowej masy ciała";
                    textAnswer2 = "utrata płynu 5-10% wyjściowej masy ciała";
                    textAnswer3 = "utrata płynu przekracza 10% wyjściowej masy ciała";
                    textAnswer4 = "utrata płynu nie przekracza 15% wyjściowej masy ciała";
                    numAnswer = 1;
                    break;
                case 3:
                    textQuestion = "Wskaż zdanie prawidłowe dotyczące zasad funkcjonowania nocnej i świątecznej opieki lekarskiej i pielęgniarskiej w POZ:";
                    textAnswer1 = "w przypadkach uzasadnionych medycznie lekarz wydaje skierowanie na konsultacje specjalistyczne ";
                    textAnswer2 = "wszystkie zdania są prawidłowe";
                    textAnswer3 = "świadczenia udzielane są tylko w przypadku zaostrzenia choroby przewlekłej np. kolejny, umiarkowany napad astmy oskrzelowej";
                    textAnswer4 = "objęcie tą formą opieki nie wymaga składania dodatkowych, imiennych deklaracji wyboru lekarza i pielęgniarki opieki nocnej i świątecznej w poz";
                    numAnswer = 2;
                    break;
                case 4:
                    textQuestion = "Jakie są szczepionki nieobowiązkowe?";
                    textAnswer1 = "ospa wietrzna";
                    textAnswer2 = "świnka";
                    textAnswer3 = "Neisseria mengitidis";
                    textAnswer4 = "streptococcus pneumoniae";
                    numAnswer = 1;
                    break;
                case 5:
                    textQuestion = "Zabieg Credego, to:";
                    textAnswer1 = "podanie noworodkowi płynnej mieszanki potrzebnych minerałów";
                    textAnswer2 = "podstawowa opieka nowordka";
                    textAnswer3 = "zabieg polegający na zmuszenia noworodka do płaczu";
                    textAnswer4 = "zakropienie noworodkowi oczu azotanem srebra";
                    numAnswer = 4;
                    break;
                case 6:
                    textQuestion = "Kardiowersja jest sprzężona z:";
                    textAnswer1 = "załamkiem R";
                    textAnswer2 = "załamkiem P";
                    textAnswer3 = "odcinkiem QR";
                    textAnswer4 = "odcinkiem QRS";
                    numAnswer = 1;
                    break;
                case 7:
                    textQuestion = "W którym miejscu przykładamy łyżki podczas kardiowersji?";
                    textAnswer1 = "prawy i lewy koniuszek serca";
                    textAnswer2 = "pierwsza do mostka, druga między łopatkami pacjenta";
                    textAnswer3 = "lewy koniuszek serca, prawa okolica podobojczykowa";
                    textAnswer4 = "mostka pacjenta";
                    numAnswer = 3;
                    break;
                case 8:
                    textQuestion = "Podczas wykonywania EKG zauważasz, że w zapisie odprowadzenia AVR pojawiły się artefakty. Sprawdzisz, czy prawidłowo przylega i jest nawilżona elektroda umieszczona na:";
                    textAnswer1 = "czwartej przestrzeni międzyżebrowej po prawej stronie mostka";
                    textAnswer2 = "prawej kończynie górnej";
                    textAnswer3 = "prawej i lewej kończynie dolnej";
                    textAnswer4 = "lewej kończynie dolnej";
                    numAnswer = 2;
                    break;
                case 9:
                    textQuestion = "Kto przyznaje medal Florence Nightingale?";
                    textAnswer1 = "Międzynarodowy Czerwony Krzyż";
                    textAnswer2 = "ONZ";
                    textAnswer3 = "NWO";
                    textAnswer4 = "WHO";
                    numAnswer = 1;
                    break;
                case 10:
                    textQuestion = "Ktore odprowadzenia w EKG sa dwubiegunowe?";
                    textAnswer1 = "aVr, aVl, aVf";
                    textAnswer2 = "I,II,II";
                    textAnswer3 = "V1-V3";
                    textAnswer4 = "V4-V6";
                    numAnswer = 3;
                    break;
                case 11:
                    textQuestion = "Do izby przyjęć trafił pacjent z bólem zamostkowym promieniującym do lewej kończyny górnej. Chory był po amputacji prawej kończyny dolnej. Elektrodę uziemiającą - ,,0’’ umieścisz na:";
                    textAnswer1 = "na prawej kończynie górnej";
                    textAnswer2 = "uznasz, że nie ma możliwości przeprowadzenia badania";
                    textAnswer3 = "umieścisz na którejkolwiek kończynie, gdyż nie ma to znaczenia dla zapisu EKG";
                    textAnswer4 = "na lewej kończynie dolnej";
                    numAnswer = 3;
                    break;
                case 12:
                    textQuestion = "Wzor na BMI";
                    textAnswer1 = "kg/m";
                    textAnswer2 = "kg/m^2";
                    textAnswer3 = "m/kg";
                    textAnswer4 = "kg/dm^3";
                    numAnswer = 2;
                    break;
                case 13:
                    textQuestion = "WHR oblicza się:";
                    textAnswer1 = "dzieląc obwód talii przez obwód uda x2";
                    textAnswer2 = "dzieląc masę ciała w kilogramach przez wzrost w metrach do kwadratu";
                    textAnswer3 = "dzieląc obwód brzucha przez obwód bioder";
                    textAnswer4 = "dzieląc obwód talii przez obwód bioder";
                    numAnswer = 4;
                    break;
                case 14:
                    textQuestion = "Typ Marasmus, to?";
                    textAnswer1 = "zmniejszona masa ciała";
                    textAnswer2 = "obniżone wskaźniki antropomertryczne";
                    textAnswer3 = "prawidłowe stężenie białek";
                    textAnswer4 = "wszystkie powyższe";
                    numAnswer = 4;
                    break;
                case 15:
                    textQuestion = "Typ Kwashirkor, to?";
                    textAnswer1 = "spadek stężenia białek surowicy";
                    textAnswer2 = "spadek odporności komórkowej i humoralnej";
                    textAnswer3 = "zachowane lub podwyższone wskaźniki antropomertryczne";
                    textAnswer4 = "wszystkie powyższe";
                    numAnswer = 4;
                    break;
                case 16:
                    textQuestion = "Prawidłowe wartości wskaźnika masy ciała (BMI) wg Światowej Organizacji Zdrowia (WHO) mieszczą się w zakresie:";
                    textAnswer1 = "17,5-20,5";
                    textAnswer2 = "18,5-24,9";
                    textAnswer3 = "20-25";
                    textAnswer4 = "wszystkie odpowiedzi są fałszywe";
                    numAnswer = 2;
                    break;
                case 17:
                    textQuestion = "Wartości BMI świadczące o niedożywieniu, to:";
                    textAnswer1 = "20-25";
                    textAnswer2 = "18.5-24.9";
                    textAnswer3 = "17.5-19";
                    textAnswer4 = "18-20";
                    numAnswer = 3;
                    break;
                case 18:
                    textQuestion = "Skala Score do czego służy?";
                    textAnswer1 = "ocena zdolności regeneracyjnej organizmu";
                    textAnswer2 = "ocena zdrowia poszkodowanego w wypadku";
                    textAnswer3 = "ocena ryzyka zgonu danej osoby z powodu chorób ukladu sercowo - naczyniowego w ciagu nastepnych 10 lat";
                    textAnswer4 = "żadna odpowiedź nie jest prawidłowa";
                    numAnswer = 3;
                    break;
                case 19:
                    textQuestion = "Co doradzisz pacjentowi z uzależnieniem od nikotyny?";
                    textAnswer1 = "środki zastępcze nikotynowe";
                    textAnswer2 = "przedstawisz skale ryzyka SCORE";
                    textAnswer3 = "zmotywujesz przeprowadzisz test uzaleznienia od nikotyny wg Fagerströna";
                    textAnswer4 = "wszystkie powyższe";
                    numAnswer = 4;
                    break;
                case 20:
                    textQuestion = "Zespół Hoigne, przy i.m. podanie leku do żyły (zawiesina, oleisty, krystaliczny) objawia się";
                    textAnswer1 = "tachykardia";
                    textAnswer2 = "paniczny lęk z uczuciem zagrozenia życia";
                    textAnswer3 = "zaburzenia świadomości";
                    textAnswer4 = "wszystkie powyższe";
                    numAnswer = 4;
                    break;
                case 21:
                    textQuestion = "Przełom tyreostatyczny, to:";
                    textAnswer1 = "odwodnienie, hipokaliemia, hiponatremia, niepokój";
                    textAnswer2 = "obniżony poziom hormonów tyreostatycznych, obniżenie ciśnienia tętniczego, wzrost temperatury, niepokój, pobudzenie";
                    textAnswer3 = "podwyższony poziom hormonów tyreostatycznych: wzrost ciśnienia tętniczego, wzrost temperatury, hiperkalcemia, hiperpotasemia, hiperglikemia";
                    textAnswer4 = "żadna odpowiedź nie jest prawidłowa";
                    numAnswer = 3;
                    break;
                case 22:
                    textQuestion = "Prosze podac 5mg leku. Stężenie podstawowe 25 mg- 2ml";
                    textAnswer1 = "0,4 ml";
                    textAnswer2 = "0,8 ml";
                    textAnswer3 = "1 ml";
                    textAnswer4 = "1,2 ml";
                    numAnswer = 1;
                    break;
                case 23:
                    textQuestion = "Co to jest ezofagoskopia?";
                    textAnswer1 = "badanie odcinka jelita cienkiego";
                    textAnswer2 = "badanie wziernikowe przy zapaleniu ucha środkowego";
                    textAnswer3 = "inaczej gastroskopia";
                    textAnswer4 = "endoskopia przełyku";
                    numAnswer = 4;
                    break;
                case 24:
                    textQuestion = "Przed przystąpieniem pacjenta do doustnego testu tolerancji glukozy (OGTT) według WHO muszą być spełnione następujące warunki:";
                    textAnswer1 = "na czczo po 1 dobie nieograniczonej diety i wytężonym wysiłku fizycznym.";
                    textAnswer2 = "pacjent musi być na czczo, po co najmniej trzech dniach nieograniczonej diety i nieograniczonym wysiłku fizycznym.";
                    textAnswer3 = "na czczo po 2 dobach nieograniczonej diety i nieograniczonej aktywności fizycznej";
                    textAnswer4 = "pacjent przychodzi na czczo. Wysiłek i dieta nie mają zasadniczego znaczenia";
                    numAnswer = 2;
                    break;
                case 25:
                    textQuestion = "Zaznacz zdanie prawdziwe. Doustny test tolerancji glukozy pozwala na zdiagnozowanie:";
                    textAnswer1 = "cukrzycy, nieprawidłowej glikemii na czczo, upośledzonej tolerancji węglowodanów";
                    textAnswer2 = "cukrzycy i nieprawidłowej glikemii na czczo";
                    textAnswer3 = "cukrzycy";
                    textAnswer4 = "nieprawidłowej tolerancji węglowodanów";
                    numAnswer = 1;
                    break;
                case 26:
                    textQuestion = "Koronaroplastyka to zabieg polegający na:";
                    textAnswer1 = "wszczepieniu stenta lub balonikowaniu naczyń wieńcowych serca";
                    textAnswer2 = "wszczepieniu stenta do naczyń wieńcowych lub tętnicy udowej";
                    textAnswer3 = "udrożnieniu tętnic i naczyń żylnych";
                    textAnswer4 = "wszystkie powyższe są prawdziwe";
                    numAnswer = 1;
                    break;
                case 27:
                    textQuestion = "W przypadku terapii izotopowej u pacjentów z nadczynnością tarczycy, zalecisz:";
                    textAnswer1 = "profilaktykę zapalenia ślinianek, picie soku z cytryny w celu pobudzenia wydzielania śliny";
                    textAnswer2 = "kobietom w wieku rozrodczym niezachodzenie w ciąże przed upływem 6-12 miesięcy od zakończenia radioterapii";
                    textAnswer3 = "cierpliwość, gdyż odczuwalne skutki terapii nie pojawią się natychmiast, rezultaty osiąga się po kilku tygodniach";
                    textAnswer4 = "wszystkie powyższe prawdziwe";
                    numAnswer = 4;
                    break;
                case 28:
                    textQuestion = "Wskazówki zachowawcze dla pacjenta z rozpoznaniem choroby refluksowej przełyku to:";
                    textAnswer1 = "powstrzymanie się od spożywania posiłków tuż po spoczynku nocnym, dobieranie odzieży dopasowanej, wysokie ułożenie do snu";
                    textAnswer2 = "powstrzymanie się od spożywania posiłków i picia przed udaniem się na spoczynek nocny, unikanie pokarmów wywołujących zgagę, noszenie luźnej nieuciskującej odzieży, płaskie ułożenie do snu";
                    textAnswer3 = "powstrzymanie się od spożywania posiłków i picia przed udaniem się na spoczynek nocny, unikanie pokarmów wywołujących zgagę, noszenie luźnej nieuciskującej odzieży, wysokie ułożenie do snu";
                    textAnswer4 = "wszystkie powyższe prawdziwe";
                    numAnswer = 4;
                    break;
                case 29:
                    textQuestion = "W przypadku terapii izotopowej u pacjentów z nadczynnością tarczycy, zalecisz:";
                    textAnswer1 = "profilaktykę zapalenia ślinianek, picie soku z cytryny w celu pobudzenia wydzielania śliny";
                    textAnswer2 = "kobietom w wieku rozrodczym niezachodzenie w ciąże przed upływem 6-12 miesięcy od zakończenia radioterapii";
                    textAnswer3 = "cierpliwość, gdyż odczuwalne skutki terapii nie pojawią się natychmiast, rezultaty osiąga się po kilku tygodniach";
                    textAnswer4 = "wszystkie powyższe prawdziwe";
                    numAnswer = 4;
                    break;
                case 30:
                    textQuestion = "Gdzie znajduje się odprowadzenie V1?";
                    textAnswer1 = "między prawym przedramieniem a lewym podudziem";
                    textAnswer2 = "IV międzyżebrze po prawej stronie";
                    textAnswer3 = "V międzyżebrze w linii środkowo-obojczykowej";
                    textAnswer4 = "między lewym przedramieniem a lewym podudziem";
                    numAnswer = 2;
                    break;
                case 31:
                    textQuestion = "Którą profilaktykę̨ może wykonywać́ pielęgniarka samodzielnie?";
                    textAnswer1 = "gruźlica";
                    textAnswer2 = "POChP";
                    textAnswer3 = "układ krążenia";
                    textAnswer4 = "cukrzyca";
                    numAnswer = 1;
                    break;
                case 32:
                    textQuestion = "Jaki filtr stosowany jest w dializie otrzewnowej";
                    textAnswer1 = "hemodializa";
                    textAnswer2 = "UV";
                    textAnswer3 = "otrzewna";
                    textAnswer4 = "osmoza";
                    numAnswer = 3;
                    break;
                case 33:
                    textQuestion = "Jak powinna się zachowywać prawidłowa przetoko tętniczo – żylna:";
                    textAnswer1 = "Tętnić i nie szumić";
                    textAnswer2 = "Tętnić́ i szumić";
                    textAnswer3 = "Nie tętnić i nie szumić";
                    textAnswer4 = "Szumić i nie tętnić";
                    numAnswer = 2;
                    break;
                case 34:
                    textQuestion = "Jakie rany goja się przez rychłozrost?";
                    textAnswer1 = "złamanie otwarte";
                    textAnswer2 = "rana oparzeniowa";
                    textAnswer3 = "odleżyna";
                    textAnswer4 = "rana czysta";
                    numAnswer = 4;
                    break;
                case 35:
                    textQuestion = "Jakie są najczęstsze powikłania po pooperacyjne u osób starszych?";
                    textAnswer1 = "powstawanie odleżyn";
                    textAnswer2 = "zaburzenia oddechowe";
                    textAnswer3 = "strach przed jazdą rowerem miejskim z powodu endoprotezy";
                    textAnswer4 = "zaburzenia krażenia";
                    numAnswer = 4;
                    break;
                case 36:
                    textQuestion = "Aby uniknąć powikłań w układzie krążenia, pielęgniarka:";
                    textAnswer1 = "zaleca picie dużej ilości wody";
                    textAnswer2 = "szybko motywuje do wstawania z łóżka i chodzenia";
                    textAnswer3 = "masuje kończyny pacjenta";
                    textAnswer4 = "zaleca wykonywanie ćwiczeń fizycznych";
                    numAnswer = 2;
                    break;
                case 37:
                    textQuestion = "Nowoczesny POZ:";
                    textAnswer1 = "realizowanie świadczeń w sposób ciągły, skoordynowany i holistyczny";
                    textAnswer2 = "posiada skomputeryzowane struktury";
                    textAnswer3 = "pozwala na diagnozę powszechnych chorób poprzez internet";
                    textAnswer4 = "wszystkie powyższe";
                    numAnswer = 1;
                    break;
                case 38:
                    textQuestion = "Badanie ogólne moczu – postępowanie:";
                    textAnswer1 = "na czczo, zaraz po przebudzeniu, po wypiciu dużej ilości wody";
                    textAnswer2 = "na czczo, zaraz po przebudzeniu, podmyć sie, mocz ze środkowego strumienia";
                    textAnswer3 = "na czczo, po 4 godzinach aktywności";
                    textAnswer4 = "nie ma zastrzeżen co do bycia na czczo";
                    numAnswer = 2;
                    break;
                case 39:
                    textQuestion = "Kobieta nieprzytomna z zachowanym krążeniem, jak ją ułożysz?";
                    textAnswer1 = "na brzuchu";
                    textAnswer2 = "trendelenburga";
                    textAnswer3 = "pozycja bezpieczna";
                    textAnswer4 = "płasko na wznak";
                    numAnswer = 3;
                    break;
                case 40:
                    textQuestion = "System per capita, założenia:";
                    textAnswer1 = "stałe dochody";
                    textAnswer2 = "proste określenie przychodów praktyki";
                    textAnswer3 = "dochód świadczeniodawcy jest uzależniony od liczby podopiecznych";
                    textAnswer4 = "wszystkie powyższe";
                    numAnswer = 4;
                    break;
                case 41:
                    textQuestion = "System rozliczania w POZ to:";
                    textAnswer1 = "stawka referencyjna";
                    textAnswer2 = "stawka akordowa";
                    textAnswer3 = "stawka godzinowa";
                    textAnswer4 = "stawka kapitacyjna";
                    numAnswer = 4;
                    break;
                case 42:
                    textQuestion = "Dziecko 3 miesięczne płacze przez? Zaznacz zdanie FAŁSZYWE:";
                    textAnswer1 = "przekarmienie";
                    textAnswer2 = "mokra pielucha";
                    textAnswer3 = "brak ulubionej zabawki";
                    textAnswer4 = "głośna muzyka";
                    numAnswer = 3;
                    break;
                case 43:
                    textQuestion = "Gdzie nie badamy temperatury u dziecka?";
                    textAnswer1 = "ucho";
                    textAnswer2 = "pacha";
                    textAnswer3 = "odbyt";
                    textAnswer4 = "pachwina";
                    numAnswer = 2;
                    break;
                case 44:
                    textQuestion = "Badanie ogólne moczu – postępowanie:";
                    textAnswer1 = "na czczo, zaraz po przebudzeniu, po wypiciu dużej ilości wody";
                    textAnswer2 = "na czczo, zaraz po przebudzeniu, podmyć sie, mocz ze środkowego strumienia";
                    textAnswer3 = "na czczo, po 4 godzinach aktywności";
                    textAnswer4 = "nie ma zastrzeżen co do bycia na czczo";
                    numAnswer = 2;
                    break;
                case 45:
                    textQuestion = "Zaznacz zdanie prawdziwe. Problemami współczesnego świata są:";
                    textAnswer1 = "owijanie książek w gazetę w strachu przed zarazkami";
                    textAnswer2 = "codzienne zmagania z uczuleniem na wodę";
                    textAnswer3 = "masło które uczula";
                    textAnswer4 = "wszystkie powyższe odpowiedzi są prawidłowe";
                    numAnswer = 4;
                    break;
                case 46:
                    textQuestion = "3 faza II etapu procesu pielęgnowania:";
                    textAnswer1 = "gromadzenie danych";
                    textAnswer2 = "diagnoza";
                    textAnswer3 = "ewaluacja";
                    textAnswer4 = "planowanie";
                    numAnswer = 4;
                    break;
                case 47:
                    textQuestion = "Jeden wymiennik węglowodanowy 1 WW to:";
                    textAnswer1 = "produkt z którego węglowodany wchłaniają się powoli";
                    textAnswer2 = "ilość danego produktu zawierająca 10 g węglowodanów przyswajalnych";
                    textAnswer3 = "10 gram produktu o niskim indeksie glikemicznym";
                    textAnswer4 = "porcja węglowodanów przeznaczona do spożycia podczas jednego posiłku";
                    numAnswer = 2;
                    break;
                case 48:
                    textQuestion = "Odleżyny – jakie są skale odleżyn:";
                    textAnswer1 = "Douglas, Barthel, Torrence";
                    textAnswer2 = "Barthel, Torrence, Norton";
                    textAnswer3 = "Norton, Douglas, Waterloo";
                    textAnswer4 = "Torrence, Douglas, Norton";
                    numAnswer = 3;
                    break;
                case 49:
                    textQuestion = "Pielęgnacja dziecka z AZS (atopowe zapalenie skóry):";
                    textAnswer1 = "unikanie produktów myjących na bazie mydła";
                    textAnswer2 = "usuwanie drażniących substancji";
                    textAnswer3 = "pielęgnacja włosów";
                    textAnswer4 = "wszystkie odpowiedzi są fałszywe";
                    numAnswer = 2;
                    break;
                case 50:
                    textQuestion = "Przy której z chorób nie wystawia się na słońce?";
                    textAnswer1 = "AZS";
                    textAnswer2 = "gorączka reumatyczna";
                    textAnswer3 = "toczeń rumieniowaty układowy";
                    textAnswer4 = "rzeżączka";
                    numAnswer = 3;
                    break;
                case 51:
                    textQuestion = "Wskaż zdanie prawdziwe. Wskazania do żywienia pozajelitowego, to:";
                    textAnswer1 = "długi stan utraty przytomności, zespół złego wchłaniania, poparzenie przełyku";
                    textAnswer2 = "przetoki jelitowe, rozległa resekcji jelit";
                    textAnswer3 = "ciężkie zapalenie jelita, przedłużająca się atonia jelit";
                    textAnswer4 = "wszystkie odpowiedzi są prawidłowe";
                    numAnswer = 4;
                    break;
                case 52:
                    textQuestion = "Współczesny trend w opiece nad chorym:";
                    textAnswer1 = "holizm";
                    textAnswer2 = "wsparcie psychologiczne";
                    textAnswer3 = "dostęp do internetu";
                    textAnswer4 = "pomoc pielęgniarska 24/7";
                    numAnswer = 1;
                    break;
                case 53:
                    textQuestion = "Świadczenia pielęgniarki szkolnej nie obejmują:";
                    textAnswer1 = "prowadzenia grupowej profilaktyki fluorkowej w klasach I-VI";
                    textAnswer2 = "wykonywania szczepień ochronnych zgodnych z kalendarzem szczepień";
                    textAnswer3 = "częstego poradnictwa dla uczniów z problemami zdrowotnymi";
                    textAnswer4 = "wykonywania i interpretowania testów przesiewowych";
                    numAnswer = 2;
                    break;
                case 54:
                    textQuestion = "Ustawa powołująca Samorząd Pielęgniarek i Położnych powstała w roku:";
                    textAnswer1 = "1995";
                    textAnswer2 = "1991";
                    textAnswer3 = "1996";
                    textAnswer4 = "1980";
                    numAnswer = 2;
                    break;
                case 55:
                    textQuestion = "Świadczenia diagnostyczne pielęgniarki POZ nie obejmują:";
                    textAnswer1 = "przeprowadzania wywiadów środowiskowych";
                    textAnswer2 = "oceny wydolności pielęgnacyjno-opiekuńczej rodziny";
                    textAnswer3 = "pobierania materiału do badań diagnostycznych w gabinecie zabiegowym";
                    textAnswer4 = "oceny i monitorowania bólu u pacjenta";
                    numAnswer = 3;
                    break;
                case 56:
                    textQuestion = "Pielęgnacja pacjenta po wszczepeniu by-passów, to:";
                    textAnswer1 = "wykonywanie ćwiczeń na brzuchu";
                    textAnswer2 = "ćwiczenia rozciągające klatkę piersiową";
                    textAnswer3 = "ograniczenie ruchów i wysiłku pacjenta";
                    textAnswer4 = "wykonywanie toalety drzewa oskrzelowego";
                    numAnswer = 4;
                    break;
                case 57:
                    textQuestion = "Przyczyny ostrego zapalenia trzustki:";
                    textAnswer1 = "anorektyzm";
                    textAnswer2 = "hiperlipidemia";
                    textAnswer3 = "nagłe odstawienie alkoholu";
                    textAnswer4 = "wykonywanie odpowiedzi są prawidłowe";
                    numAnswer = 2;
                    break;
                case 58:
                    textQuestion = "Wskaż zdanie prawdziwe. Amputacja konwencjonalna i fizjologiczna różni się tak:";
                    textAnswer1 = "konwencjonalna: dłuższa rehabilitacja, fizjologiczna: rehabilitacja bardziej efektywna";
                    textAnswer2 = "konwencjonalna: mniejszy ból, fizjologiczna: ból utrzymuje się dłużej";
                    textAnswer3 = "konwencjonalna: nie dochodzi do opóźnienia gojenia się rany, fizjologiczna: rana goi się dłużej";
                    textAnswer4 = "wszystkie zdania są prawidłowe";
                    numAnswer = 1;
                    break;
                case 59:
                    textQuestion = "W profilaktyce i leczeniu obrzęku limfatycznego stosuje się:";
                    textAnswer1 = "głaskanie całej kończyny od części dystalnej w kierunku proksymalnym";
                    textAnswer2 = "rozcieranie ruchem kolistym samymi opuszkami palców, zakreślając kółeczka";
                    textAnswer3 = "głaskanie barku - ruch rozpoczyna się od łokcia w górę, prowadząc przez bark aż do łopatki";
                    textAnswer4 = "wszystkie zdania są prawidłowe";
                    numAnswer = 4;
                    break;
                case 60:
                    textQuestion = "Podaj zakres informacji w strkturze STAN-PROBLEM w diagnozie aktualnej:";
                    textAnswer1 = "biologiczny, społeczny, edukacyjny, rodzinny, psychiczny";
                    textAnswer2 = "biologiczny, społeczny, kluczowy, rodzinny, psychiczny";
                    textAnswer3 = "biologiczny, społeczny, edukacyjny, rodzinny, tradycyjny";
                    textAnswer4 = "naturalny, społeczny, edukacyjny, rodzinny, psychiczny";
                    numAnswer = 1;
                    break;
                case 61:
                    textQuestion = "14 potrzeb człowieka to model pielęgnowania wg:";
                    textAnswer1 = "Orem";
                    textAnswer2 = "Douglas";
                    textAnswer3 = "Henderson";
                    textAnswer4 = "Torrence";
                    numAnswer = 3;
                    break;
                case 62:
                    textQuestion = "Do rutynowego wyposażenia gabinetu pielęgniarki POZ nie należy:";
                    textAnswer1 = "zestaw przeciwwstrząsowy";
                    textAnswer2 = "waga medyczna dla niemowląt";
                    textAnswer3 = "aparat EKG";
                    textAnswer4 = "tablice do badania ostrości wzroku";
                    numAnswer = 3;
                    break;
                case 63:
                    textQuestion = "Co zrobisz? Trudności w poruszaniu się, spowodowane stanem po urazie kończyny, doprowadziły u pacjentki do deficytu agendy samoopieki:";
                    textAnswer1 = "wykonanie kąpieli pacjentki w wannie, jeden raz w tygodniu przez okres 1 miesiąca";
                    textAnswer2 = "polecenie wizyty u kosmetyczki";
                    textAnswer3 = "wytłumaczysz pacjentce, że robiła źle";
                    textAnswer4 = "zachęcisz do uczestnictwa w grupie wsparcia";
                    numAnswer = 1;
                    break;
                case 64:
                    textQuestion = "Data powstania Karty Praw Pacjenta, to:";
                    textAnswer1 = "1995";
                    textAnswer2 = "1998";
                    textAnswer3 = "1997";
                    textAnswer4 = "1999";
                    numAnswer = 2;
                    break;
                case 65:
                    textQuestion = "Jakie mleko podasz 5 miesięcznemu niemowlakowi?";
                    textAnswer1 = "początkowe";
                    textAnswer2 = "następne";
                    textAnswer3 = "junior";
                    textAnswer4 = "bez znaczenia";
                    numAnswer = 1;
                    break;
                case 66:
                    textQuestion = "Wskaż zdanie prawidłowe dotyczące zasad funkcjonowania nocnej i świątecznej opieki lekarskiej i pielęgniarskiej w POZ";
                    textAnswer1 = "świadczenia udzielane są tylko w przypadku zaostrzenia choroby przewlekłej np. kolejny, umiarkowany napad astmy oskrzelowej";
                    textAnswer2 = "w przypadkach uzasadnionych medycznie lekarz wydaje skierowanie na konsultacje specjalistyczne";
                    textAnswer3 = "objęcie tą formą opieki nie wymaga składania dodatkowych, imiennych deklaracji wyboru lekarza i pielęgniarki opieki nocnej i świątecznej w poz";
                    textAnswer4 = "wszystkie zdania są prawidłowe";
                    numAnswer = 4;
                    break;
                case 67:
                    textQuestion = "Co należy podać pacjentowi podczas zabiegu gastroskopii?";
                    textAnswer1 = "miskę nerkowatą";
                    textAnswer2 = "leki znieczulające";
                    textAnswer3 = "ciepłe okrycie";
                    textAnswer4 = "poduszkę pod głowę";
                    numAnswer = 1;
                    break;
                case 68:
                    textQuestion = "Co to jest jatrogenność?";
                    textAnswer1 = "powstawanie kolek gazowych po szpitalnym jedzeniu";
                    textAnswer2 = "działanie personelu medycznego mające szkodliwy wpływ na pacjenta";
                    textAnswer3 = "narastająca niechęć do personelu szpitalnego";
                    textAnswer4 = "narastający lęk przed badaniami";
                    numAnswer = 2;
                    break;
                case 69:
                    textQuestion = "W której formie afazji całkowity kontakt słowny jest zniesiony?";
                    textAnswer1 = "afazja ruchowa";
                    textAnswer2 = "afazja amnestetyczna";
                    textAnswer3 = "afazja czuciowo-ruchowa";
                    textAnswer4 = "afazja całkowita";
                    numAnswer = 4;
                    break;
                case 70:
                    textQuestion = "Techniki zbierania danych do karty pacjenta:";
                    textAnswer1 = "werbalne, pomiar";
                    textAnswer2 = "obserwacja, analiza danych";
                    textAnswer3 = "badanie pacjenta";
                    textAnswer4 = "wszystkie zdania są prawidłowe";
                    numAnswer = 4;
                    break;
                default:
                    break;
            }
        }



    }
}
