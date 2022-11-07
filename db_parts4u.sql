
CREATE DATABASE IF NOT EXISTS db_parts4u;

CREATE TABLE IF NOT EXISTS `products` (
  `id` int(11) NOT NULL,
  `Name` varchar(100) COLLATE utf8mb4_danish_ci NOT NULL,
  `Type` varchar(100) COLLATE utf8mb4_danish_ci NOT NULL,
  `Description` varchar(2500) COLLATE utf8mb4_danish_ci DEFAULT NULL,
  `ItemNumber` varchar(100) COLLATE utf8mb4_danish_ci NOT NULL,
  `Cost` double NOT NULL,
  `typeId` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_danish_ci;

INSERT INTO `products` (`id`, `Name`, `Type`, `Description`, `ItemNumber`, `Cost`, `typeId`) VALUES
(101, 'Iso stik, Pioneer QDP3012', 'Reservedele', ' Passer til følgende modeller: DEH-1300MP DEH-1400UB DEH-140UB DEH-150MP DEH-2300UB DEH-2400UB DEH-2500Ui DEH-3300UB DEH-3400UB DEH-4200SD DEH-4300UB DEH-6300SD MVH-1400UB ', '34961', 22900, 1),
(105, 'Kølervæske \"Klar til brug\" 4 liter', 'Tilbehør', 'Prestone kølemiddel / frostvæske er førende inden for bilteknologi og er velegnet til brug for alle mærker, alle modeller og alle motorer! Det kan blandes med enhver farve eller type af kølemiddel / frostvæske, der allerede findes i system. Den patenterede Cor-Guard teknologi tilbyder overlegen beskyttelse mod korrosion og giver et ekstra beskyttende lag, som beskytter alle komponenter i køling system, mod kavitation, korrosion, erosion og afskalning. Cor-Guard teknologi giver uovertruffen beskyttelse i op til 480.000 km eller 10 år. Brugt som første påfyldning af flere førende bilproducenter.', '990000804802', 129, 1),
(108, 'Styrthjelm Pilot m/solbrille MT Le Mans2 SV matsort str. S', 'Udstyr', 'Brun/sort interiør med hvide syninger, sammen med kromkant og matsort lakering, giver det denne hjelm det helt rigtige retrolook. Hjelmen har rigtig lækker pasform og føles minimalistisk at have på. Den er udstyret med indbygget trinløs solbrille. Le Mans er den perfekte hjelm, hvis du kører klassisk MC, eller hvis du bare vil se sejest ud på knallerttur med drengene.', '99606654621', 599, 2),
(109, 'Navigation Garmin zumo 346LMT-S MC Vesteuropa', 'Udstyr', 'Lav ruter om til eventyr, og oplev dem med vennerne. zumo 346 er den robuste 4,3\" motorcykelnavigator, der giver dig mulighed for at finde de snoede veje, dele GPX-filer trådløst til gruppeture og forblive tilsluttet via Smartphone Link app. Indbygget Wi-Fi giver mulighed for nemme kortopdateringer, og Bluetooth lader sumo styre musik på din telefon Inkluderer live-trafik og vejr, live-tracking, håndfri telefoni, smart-notifikationer fra din telefon. Motorcyklistadvarsler fremmer en sikrere tur med advarsler om skarpe kurver, jernbaneoverskæringer, rødt lys og hastighedskameraer. Den robuste zumo er desuden bygget til at modstå brændstofdampe, UV-stråler, regn og voldsomt vejr.', '30776', 2899, 2),
(111, 'Tændrørsnøgle 14 mm T-Type', 'Værktøj', 'Til 14 mm tændrør. Af forkromet CrV-stål. Forsynet med magnet. Ekstra lange og tyndvæggede toppe. Velegnet til motorer, hvor tændrøret sidder langt nede i topstykket. Med 12-kantfatning.', '47008', 49, 2),
(115, 'Shimano kranksæt Sora FC-R3000 9-speed 175mm sort', 'Reservedel', 'Shimano Sora R3000 kranksæt til 9-speed, med compact gearing (50-34). Solidt kranksæt til landevejsrytteren som kører mange kilometer. Kranksættet kan kombineres med Shimanos andre 9-speed komponenter. Bruger Hollowtech II krankboks. Pedalarmslængde: 175mm. Fix mål: 104mm.', '220100044', 799, 3),
(149, 'Saphe One trafikalarm', 'Tilbehør', ' Saphe One placeres i bilen og forbindes via Bluetooth til en app på din smartphone. ', '42625', 29900, 1),
(150, 'Terninger', 'Udstyr', 'Ved køb medfølger gratis en Winderbaum. Terningerne findes i grøn, sort og hotpink.', '1234', 179, 1),
(151, 'Charger Kit 1210 Flex 10A', 'Tilbehør', 'Det ideelle lader kit til køretøjer med stort strømforbrug DEFA ChargerKit består af MultiCharger 1210 og tilslutningssæt. Dagens moderne biler er propfyldt fuld af elektronik, der bruger strøm fra batteriet, selv når bilen er parkeret. Batteriet skal oplades en gang imellem. Anvendelse af komfortudstyr såsom: - Elektrisk opvarmede bagrude, spejle og forrude - Elektriske opvarmede sæder - Keramiske varmeelementer - Brændstof-baserede supplerende opvarmning ...forbruger meget strøm fra bilens batteri.', '22505', 2599, 1),
(152, 'Gashåndtag Lusito Quick-gas universal inkl. venstre gummihåndtag', 'Reservedele', ' Quick-gas håndtag med stor vandring - perfekt til store karburatorer Kvalitets Quick-Gas håndtag produceret af Lusito i Portugal. Giver hurtig gasrespons og god kontrol over gasreguleringen. Til Ø22 mm styr Inkl. venstre gummihåndtag ', '99323140138', 14900, 2),
(153, 'VGA Explora Euro-5 45 km/t sort', 'Køretøj', ' GA Explora - Danmarks billigste Euro-5 scooter VGA Explora er danskernes absolutte favorit scooter. Hele 9 år i træk, har Explora været på hitlisten som Danmarks bedst sælgende scooter grundet sin lave pris og stærke driftssikkerhed. Vi har længe arbejdet intenst på en ny opdateret Explora, så scooter-Danmark kan holdes godt kørende. Vores nye Explora Euro-5 har fået et facelift, herudover får du en ny opdateret motor med brændstofsystem fra Italienske Dell\'Orto. Med den nye ekstrem driftssikre og brændstoføkonomiske 4-takts Euro-5 motor kører Explora nu helt op til 37 km/l som 30 km/t og 48 km/l som 45 km/t. Explora Euro-5 er herudover udstyret med USB ladeudtag, LED baglygte og LED positionslys. Selvom prisen på Explora Euro-5 er lav, så får du stadig pulverlarkerede alufælge og galvaniserede bolte og skruer til at modstå det danske klima. Den lave anskaffelsespris kombineret med særligt lave driftsomkostninger, gør Explora Euro-5 til en af Danmarks absolutte billigste 2-hjulede benzin køretøjer. 0 kr. i vægtafgift - Årlig ansvarsforsikring hos IF kun 899 kr. Danmarks største servicenet Husk, at du med en VGA scooter får adgang til Danmarks største servicenet. Du kan indlevere din VGA scooter i en af vores mange thansen butikker alle ugens dage. Vigtig information vedr. leveringstid på køretøjer med nummerplade Registreringspligtige køretøjer skal altid forsynes med nummerplade før, at det lovligt må benyttes på offentlig vej. Nummerplader oprettes via vores centrallager i Middelfart, hvorefter nummerplade sendes til valgte butik. Ekspeditionen tager 1-2 hverdage. Vi sender dig altid besked pr. mail eller SMS, når dit køretøj er monteret med nummerplade og klar til afhentning. ', '73150100080', 1138900, 2),
(154, 'Dæk rep. kit/lappe sæt til slangeløs dæk', 'Reservedele', 'Med dette lappesæt kan du hurtigt lappe slangeløse dæk, uden at skulle afmontere dækket. Sættet leveres komplet med værktøj, lim og dækpropper. Kan også bruges som kortvarig nødreparation på bil og MC-dæk.', '99202460000', 7995, 2),
(155, 'Lappesæt limfri 6 stk. (til slanger)', 'Reservedele', ' Lappesæt til slanger. Indhold: 6 limfri lapper, diameter 25mm. Sand papir 2,5X2,5cm. ', '210030002', 1995, 3),
(156, 'Aftrækker til shimano steps tandhjul', 'Reservedele', ' Aftrækker til shimano steps tandhjul foran. Passer bl.a. til : E8000, E6100, E7000 og E5000 Bemærk at tandhjulet er monteret med links gevind ', '260406084', 9995, 3),
(157, 'Fatbike MTB alu 24\" 7-speed sort/grøn', 'Køretøj', ' X-Zite Fatbike i let aluminiumsstel Fatbiken er kommet for at blive, og denne flotte sort/grønne 24\" er en del af thansens udbud af fatbikes til børn. Den er udstyret med fast forgaffel og mekaniske skivebremser for og bag. 7 gear fra shimano Tourney med 14-34T skruekrans sikrer gear til enhver lejlighed. Cyklen er udstyret med brede 24 x 2,60 dæk som står godt fast i løst underlag. Cyklen overholder ISO-4210 standarden for kvalitet og sikkerhed 20 års garanti mod stelbrud Leveres delvist samlet Det eneste, du skal gøre, er at montere forhjul, sadel, pedaler og styr - så er du kørende. ', '112434070', 249900, 3),
(158, 'Pedalarm FAUBER til BMX Freestyle', 'Reservedel', 'Pedalarme ud i et til BMX Fauber type krank. Pedalarms længde 170mm Gevind til krank konus og kontraring udvendig mål 21,8 mm.Not på højre pedalarm til klingen. Bredde mellem pedalarme 11 cm. Gevind str. for pedaler 1/2\"', '220114002', 149, 3),
(159, 'Cykellygte', 'Udstyr', 'Lysstærke forlygter der oplades nemt og problemfrit via USB. Lyset kan indstilles i fire forskellige styrketrin samt blinkende lys. Med snaplås, der gør det let at tage lygten af og sætte den på cyklen. Indkapslingsklasse: IP44.', '0652', 159, 3),
(160, 'BMX 20\" freestyle aluminium sort/blå', 'Køretøj', ' Skal din nye BMX være 100% PRO og gerne den sejeste på markedet, så tjek vores X-zite BMX med bl.a. super fede water-decals og blå fælge. Vores BMX er designet og sammensat af professionelle cykeldesignere, som ikke går på kompromis med kvaliteten. Alle komponenter er nøje udvalgt, så holdbarhed og kvalitet er i top. Et letvægts aluminiums stel reducerer vægten med hele 1,5 kg. i forhold til et standard stel i stål. Totalvægten er kun 13,5 kg. Styret kan rotere 360 grader, alle de gange du vil, uden at kablerne kommer i vejen. Håndtag med \"Lock on grip\" giver optimal kontrol under vanskelige moves. Du får en BMX i et højt niveau, hvor du kan udøve og træne alle de grundlæggende BMX tricks. Cyklen anbefales til børn fra 7 år og opefter. Der medfølger 4 stk. pegs: 2 stk. til for- og 2 stk. til baghjulet. Cyklen overholder ISO-4210 standarden for kvalitet og sikkerhed. 20 års garanti mod stelbrud.', '152028006', 1999, 3),
(161, 'Pæresæt H1 55W 12V CoolBlueIntense Osram', 'Reservedele', 'Cool Blue Intense-pærer fra Osram giver dig mulighed for at opnå et look i nærheden af Xenon-lys. Det kølige blå/hvide lys ser fantastisk flot ud på bilen! Med op til 4200 Kelvin er Cool Blue Intense den absolut mest blå pære på markedet - samtidigt er den 100% lovlig at køre med, hvor færdselsloven gælder. Op til 20% mere lys sammenlignet med standardpærer! Opfylder bilproducenternes høje kvalitetskrav! Sæt med 2 stk.', '40077', 199, 1),
(162, 'LED interiørlys 60x25mm 9*4LED 12V 2,1W', 'Reservedele', 'Leveres med 3 forskellige sokkeladaptere Nem og enkel upgrade af dit interiørlys/loftlys 12V 2,1W', '45840', 30, 1),
(163, 'Batteri - StartPRO', 'Reservedele', 'Model: • MDX-300 Display: LCD-grafikdisplay Temperaturkompensation:Tester-styre', '999702000007', 1849, 1),
(164, 'Benzin/dieselrør, 5m, 6mm, kobber', 'Reservedele', 'Specifikationer: Udvendig diameter: 6 mm. Længde: 5 m.', '990000000052', 249, 1),
(165, 'Gaskabel, ATV AU CVT 180cc', 'Reservedele', 'Mærke Scooped Varetype Gaskabel', '47124045200', 99, 2),
(166, 'Luftfilter komplet ATV AU CVT 180cc', 'Reservedele', 'Mærke Scooped Varetype Luftfilter', '47121012000', 299, 2),
(167, 'Nyrebælte neopren Outtrek small', 'Beklædning', 'Bæltet giver god støtte for lænden, og hjælper dig med at holde varmen, når det er koldt. Kraftig velcro og elastik sikrer tilpas og justérbar pasform, så nyrebæltet sidder godt til. Fås i størrelse S - XXL, der passer til livvidder mellem 95 - 135 cm.', '99141240120', 149, 2),
(169, 'Fjedergummi, lille (VIKA)', 'Reservedele', 'Mærke Vika Varetype Fjedergummi Info 5,0 cm på højeste punkt', '990000000001', 2995, 1),
(170, 'Håndtagssæt 120/120mm', 'Udstyr', 'Ekstra kraftige og tykke håndtag til City og MTB. 120mm lange. Sort. Ekstra tyk.', '230203042', 4995, 3),
(171, 'Bremsegreb til rullebremse venstre sort', 'Reservedele', 'Bremsegreb specielt designet til rullebremser. Udvekslingen i grebet, og udformningen af grebsklingen, gør at du får den mest optimale trækkraft, når du bruger grebet med en rullebremse. Sort. Forbremse. Til rullebremse.', '230201023', 9995, 3),
(172, 'Stabiliseringsfjeder til forgaffel 9cm', 'Reservedele', 'Fjeder mellem stel og forgaffel. 9cm lang. Stabiliserer cykler så de ikke vælter. Cyklen skal være forberedt til kroge for at kunne bruges. Den sorte plasticbeskytter til fjederen skal i visse tilfælde klippes til.', '230224020', 2995, 3),
(173, 'yukjfryku', 'hgmfgm', 'ngfnxfnxf', '678', 456, 2),
(174, 'Sædevarme', 'Udstyr', 'Varmer dejligt i de kolde vintermåneder. I brunt velour eller sort kunslæder. Kan sættes til cigaretænder.', '34534', 677, 1);



CREATE TABLE IF NOT EXISTS `producttype` (
  `id` int(11) NOT NULL,
  `title` varchar(300) COLLATE utf8mb4_danish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_danish_ci;


INSERT INTO `producttype` (`id`, `title`) VALUES
(1, 'Bil produkter'),
(2, 'Motorcykel produkter'),
(3, 'Cykel produkter');


CREATE TABLE IF NOT EXISTS `sales` (
  `id` int(11) NOT NULL,
  `sale` varchar(200) COLLATE utf8mb4_danish_ci NOT NULL,
  `time` datetime NOT NULL,
  `idProduct` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_danish_ci;


INSERT INTO `sales` (`id`, `sale`, `time`, `idProduct`) VALUES
(1, 'test', '0000-00-00 00:00:00', 0),
(2, 'test', '0000-00-00 00:00:00', 0),
(3, 'test', '0000-00-00 00:00:00', 0),
(4, 'test', '0000-00-00 00:00:00', 0),
(5, 'test', '0000-00-00 00:00:00', 0),
(6, 'Batteri - StartPRO', '0000-00-00 00:00:00', 163),
(7, 'VGA Explora Euro-5 45 km/t sort', '0000-00-00 00:00:00', 153),
(8, 'Gaskabel, ATV AU CVT 180cc', '0000-00-00 00:00:00', 165),
(9, 'Dæk rep. kit/lappe sæt til slangeløs dæk', '0000-00-00 00:00:00', 154),
(10, 'Luftfilter komplet ATV AU CVT 180cc', '0000-00-00 00:00:00', 166),
(11, 'Nyrebælte neopren Outtrek small', '0000-00-00 00:00:00', 167),
(12, 'VGA Explora Euro-5 45 km/t sort', '0000-00-00 00:00:00', 153),
(13, 'Luftfilter komplet ATV AU CVT 180cc', '2021-11-17 16:15:48', 166),
(14, 'Styrthjelm Pilot m/solbrille MT Le Mans2 SV matsort str. S', '2021-11-17 16:15:56', 108),
(15, 'Tændrørsnøgle 14 mm T-Type', '2021-11-17 16:15:58', 111),
(16, 'Luftfilter komplet ATV AU CVT 180cc', '2021-11-17 16:16:00', 166),
(17, 'Dæk rep. kit/lappe sæt til slangeløs dæk', '2021-11-17 16:16:01', 154),
(18, 'VGA Explora Euro-5 45 km/t sort', '2021-11-17 16:16:03', 153),
(19, 'Styrthjelm Pilot m/solbrille MT Le Mans2 SV matsort str. S', '2021-11-17 16:16:03', 108),
(20, 'Pedalarm FAUBER til BMX Freestyle', '2021-11-17 16:21:29', 158),
(21, 'Charger Kit 1210 Flex 10A', '2021-11-17 16:21:44', 151),
(22, 'Iso stik, Pioneer QDP3012', '2021-11-17 16:24:28', 101),
(23, 'Lappesæt limfri 6 stk. (til slanger)', '2021-11-17 16:25:08', 155),
(24, 'Pedalarm FAUBER til BMX Freestyle', '2021-11-17 16:25:23', 158),
(25, 'Shimano kranksæt Sora FC-R3000 9-speed 175mm sort', '2021-11-17 16:28:04', 115),
(26, 'Saphe One trafikalarm', '2021-11-17 16:28:19', 149),
(27, 'Pedalarm FAUBER til BMX Freestyle', '2021-11-17 16:29:24', 158),
(28, 'Gaskabel, ATV AU CVT 180cc', '2021-11-17 16:29:39', 165),
(29, 'Tændrørsnøgle 14 mm T-Type', '2021-11-17 16:29:54', 111),
(30, 'Tændrørsnøgle 14 mm T-Type', '2021-11-17 16:30:54', 111),
(31, 'Lappesæt limfri 6 stk. (til slanger)', '2021-11-17 16:31:09', 155),
(32, 'Gaskabel, ATV AU CVT 180cc', '2021-11-17 17:11:53', 165),
(33, 'LED interiørlys 60x25mm 9*4LED 12V 2,1W', '2021-11-17 17:17:32', 162),
(34, 'Gaskabel, ATV AU CVT 180cc', '2021-11-17 17:18:25', 165),
(35, 'Cykellygte', '2021-11-17 17:22:02', 159),
(36, 'Aftrækker til shimano steps tandhjul', '2021-11-17 17:24:31', 156),
(37, 'Pæresæt H1 55W 12V CoolBlueIntense Osram', '2021-11-17 17:26:19', 161),
(38, 'Navigation Garmin zumo 346LMT-S MC Vesteuropa', '2021-11-17 17:26:34', 109),
(39, 'Styrthjelm Pilot m/solbrille MT Le Mans2 SV matsort str. S', '2021-11-17 17:26:49', 108),
(40, 'Pæresæt H1 55W 12V CoolBlueIntense Osram', '2021-11-17 17:27:04', 161),
(41, 'Benzin/dieselrør, 5m, 6mm, kobber', '2021-11-17 17:27:19', 164),
(42, 'Aftrækker til shimano steps tandhjul', '2021-11-17 17:27:34', 156),
(43, 'Håndtagssæt 120/120mm', '2021-11-17 17:58:05', 170),
(44, 'Saphe One trafikalarm', '2021-11-17 17:58:20', 149),
(45, 'Charger Kit 1210 Flex 10A', '2021-11-17 17:58:35', 151),
(46, 'Saphe One trafikalarm', '2021-11-17 17:58:50', 149),
(47, 'Navigation Garmin zumo 346LMT-S MC Vesteuropa', '2021-11-17 17:59:06', 109),
(48, 'Charger Kit 1210 Flex 10A', '2021-11-17 18:36:26', 151),
(49, 'Batteri - StartPRO', '2021-11-17 18:36:41', 163),
(50, 'VGA Explora Euro-5 45 km/t sort', '2021-11-17 18:59:49', 153),
(51, 'Dæk rep. kit/lappe sæt til slangeløs dæk', '2021-11-17 19:00:04', 154),
(52, 'Batteri - StartPRO', '2021-11-17 19:00:19', 163),
(53, 'Pæresæt H1 55W 12V CoolBlueIntense Osram', '2021-11-17 19:00:35', 161),
(54, 'Charger Kit 1210 Flex 10A', '2021-11-17 19:00:50', 151),
(55, 'Tændrørsnøgle 14 mm T-Type', '2021-11-17 19:01:05', 111),
(56, 'Gaskabel, ATV AU CVT 180cc', '2021-11-17 19:02:44', 165),
(57, 'Fjedergummi, lille (VIKA)', '2021-11-17 19:02:59', 169),
(58, 'Batteri - StartPRO', '2021-11-17 19:03:14', 163),
(59, 'Pæresæt H1 55W 12V CoolBlueIntense Osram', '2021-11-17 20:10:10', 161),
(60, 'Cykellygte', '2021-11-17 20:16:56', 159),
(61, 'Fjedergummi, lille (VIKA)', '2021-11-17 20:17:11', 169),
(62, 'Terninger', '2021-11-17 20:17:26', 150),
(63, 'Nyrebælte neopren Outtrek small', '2021-11-17 20:17:41', 167),
(64, 'LED interiørlys 60x25mm 9*4LED 12V 2,1W', '2021-11-17 20:17:56', 162),
(65, 'Kølervæske \"Klar til brug\" 4 liter', '2021-11-17 20:18:11', 105),
(66, 'BMX 20\" freestyle aluminium sort/blå', '2021-11-17 20:18:26', 160),
(67, 'Charger Kit 1210 Flex 10A', '2021-11-17 20:18:41', 151),
(68, 'Cykellygte', '2021-11-17 20:23:02', 159),
(69, 'Fatbike MTB alu 24\" 7-speed sort/grøn', '2021-11-17 20:24:48', 157),
(70, 'Dæk rep. kit/lappe sæt til slangeløs dæk', '2021-11-17 20:28:55', 154),
(71, 'Batteri - StartPRO', '2021-11-17 20:29:14', 163),
(72, 'VGA Explora Euro-5 45 km/t sort', '2021-11-17 20:29:29', 153),
(73, 'Luftfilter komplet ATV AU CVT 180cc', '2021-11-17 20:29:44', 166),
(74, 'Lappesæt limfri 6 stk. (til slanger)', '2021-11-17 20:29:59', 155),
(75, 'Nyrebælte neopren Outtrek small', '2021-11-17 20:30:14', 167),
(76, 'Pæresæt H1 55W 12V CoolBlueIntense Osram', '2021-11-17 20:30:29', 161),
(77, 'Shimano kranksæt Sora FC-R3000 9-speed 175mm sort', '2021-11-17 20:30:45', 115),
(78, 'Pedalarm FAUBER til BMX Freestyle', '2021-11-17 20:36:14', 158),
(79, 'Dæk rep. kit/lappe sæt til slangeløs dæk', '2021-11-17 20:36:29', 154),
(80, 'Terninger', '2021-11-17 20:36:37', 150),
(81, 'Terninger', '2021-11-17 20:36:39', 150),
(82, 'Terninger', '2021-11-17 20:36:41', 150),
(83, 'Terninger', '2021-11-17 20:36:44', 150),
(84, 'yukjfryku', '2021-11-17 20:36:59', 173),
(85, 'Luftfilter komplet ATV AU CVT 180cc', '2021-11-17 20:42:27', 166),
(86, 'Tændrørsnøgle 14 mm T-Type', '2021-11-17 20:42:33', 111),
(87, 'Styrthjelm Pilot m/solbrille MT Le Mans2 SV matsort str. S', '2021-11-17 20:42:36', 108),
(88, 'Luftfilter komplet ATV AU CVT 180cc', '2021-11-17 20:42:37', 166),
(89, 'Navigation Garmin zumo 346LMT-S MC Vesteuropa', '2021-11-17 20:42:39', 109),
(90, 'Aftrækker til shimano steps tandhjul', '2021-11-17 20:42:42', 156),
(91, 'Charger Kit 1210 Flex 10A', '2021-11-17 20:43:31', 151),
(92, 'Håndtagssæt 120/120mm', '2021-11-17 20:43:39', 170),
(93, 'Pedalarm FAUBER til BMX Freestyle', '2021-11-17 20:43:41', 158),
(94, 'Lappesæt limfri 6 stk. (til slanger)', '2021-11-17 20:43:44', 155),
(95, 'Batteri - StartPRO', '2021-11-17 20:43:46', 163),
(96, 'Bremsegreb til rullebremse venstre sort', '2021-11-17 20:43:46', 171);



CREATE TABLE  IF NOT EXISTS `stock` (
  `id` int(11) NOT NULL,
  `name` varchar(200) COLLATE utf8mb4_danish_ci NOT NULL,
  `amount` int(11) DEFAULT NULL,
  `idProducts` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_danish_ci;


INSERT INTO `stock` (`id`, `name`, `amount`, `idProducts`) VALUES
(67, 'Iso stik, Pioneer QDP3012', 230, 101),
(68, 'Saphe One trafikalarm', 15, 149),
(69, 'Terninger', 78, 150),
(70, 'Gashåndtag Lusito Quick-gas universal inkl. venstre gummihåndtag', 0, 152),
(71, 'VGA Explora Euro-5 45 km/t sort', 1010, 153),
(72, 'Lappesæt limfri 6 stk. (til slanger)', 116, 155),
(73, 'Aftrækker til shimano steps tandhjul', 107, 156),
(74, 'Fatbike MTB alu 24\" 7-speed sort/grøn', 36, 157),
(75, 'Charger Kit 1210 Flex 10A', 86, 151),
(76, 'Kølervæske \"Klar til brug\" 4 liter', 79, 105),
(77, 'Styrthjelm Pilot m/solbrille MT Le Mans2 SV matsort str. S', 74, 108),
(78, 'Navigation Garmin zumo 346LMT-S MC Vesteuropa', 80, 109),
(79, 'Dæk rep. kit/lappe sæt til slangeløs dæk', 76, 154),
(80, 'Tændrørsnøgle 14 mm T-Type', 79, 111),
(81, 'Shimano kranksæt Sora FC-R3000 9-speed 175mm sort', 71, 115),
(82, 'Pedalarm FAUBER til BMX Freestyle', 127, 158),
(83, 'Cykellygte', 80, 159),
(84, 'BMX 20\" freestyle aluminium sort/blå', 54, 160),
(85, 'Pæresæt H1 55W 12V CoolBlueIntense Osram', 85, 161),
(86, 'LED interiørlys 60x25mm 9*4LED 12V 2,1W', 95, 162),
(87, 'Batteri - StartPRO', 35, 163),
(88, 'Benzin/dieselrør, 5m, 6mm, kobber', 140, 164),
(89, 'Fjedergummi, lille (VIKA)', 141, 169),
(90, 'Gaskabel, ATV AU CVT 180cc', 140, 165),
(91, 'Luftfilter komplet ATV AU CVT 180cc', 138, 166),
(92, 'Håndtagssæt 120/120mm', 147, 170),
(93, 'Bremsegreb til rullebremse venstre sort', 144, 171),
(94, 'Stabiliseringsfjeder til forgaffel 9cm', 145, 172),
(95, 'Nyrebælte neopren Outtrek small', 139, 167),
(97, 'yukjfryku', 455, 173),
(98, 'Sædevarme', 30, 174);

ALTER TABLE `products`
  ADD PRIMARY KEY (`id`);

ALTER TABLE `producttype`
  ADD PRIMARY KEY (`id`);

ALTER TABLE `sales`
  ADD PRIMARY KEY (`id`);


ALTER TABLE `stock`
  ADD PRIMARY KEY (`id`);


ALTER TABLE `products`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=175;

ALTER TABLE `producttype`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;


ALTER TABLE `sales`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=97;

ALTER TABLE `stock`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=99;

ALTER TABLE `products`
  ADD CONSTRAINT `products_ibfk_1` FOREIGN KEY (`typeId`) REFERENCES `producttype` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;


ALTER TABLE `stock`
  ADD CONSTRAINT `stock_ibfk_1` FOREIGN KEY (`idProducts`) REFERENCES `products` (`id`);
COMMIT;
