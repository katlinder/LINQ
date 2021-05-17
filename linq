1. LINQ (Language Integrated Query) - ühtne päringu stiil, mis ühendaberinevaid allikaid ja formaate. Integreeritud C# või VB, mis kõrvaldab erinevate programeerimiskeelte ja andmekogude erisused, ja loob ühtse väljalaske. 
2. mida tähendab märk: => - Lambada väljend. Eraldab lambadaparameetrid põhiosast. Kasutatakse, et luua anonüümne funktsioon. 
3. Where - väljastab kriteeriumi funktsioonil põhineva kogumiku väärtuse.
4. OfType - filtreerib kogumikus välja spetsiifilised väärtused. 
5. ThenBy - kasutatakse sorteerimiseks suurenevas järjekorras
6. GroupBy, ToLookUp - grupeerib elemente määratud viisil. Iga grup on viisil: IGrouping<TKey, TElement> object
7. Join - ühendab kaht kogu ja prindib saadu. Ühte nimetatakse sisemiseks ja teist välimiseks koguks. 
8. GroupJoin - sama, mis “join” aga töötab grupina. 
9. Select - valib IEnumerable kogu, mis sisaldab muutuva funktsiooni elemente. 
10. All, Any - kontrollib, kas kõik (any puhul kas mingi) elementid jadas vastavad spetsiifilisele tingimusele.
11. Contains - kontroolib kas spetsiifiline element eksisteerib kogus või ei ja väljastab boolean’i.
12. Aggregate - liidab kogu väärtused.
13. Avarage - arvutab kogu numbriväärtuste keskmise
14. Count - loeb kokku kogu elemendid
15. Max - leiab jada suurima väärtuse
16. Sum - liidab jada väärtused
17. ElementAt - tagastabelemendi määratud indeksina  
ElementAtOrdefault - tagastabelemendi määratud indeksina või põhilise väärtuse kui määratud indeks õletab piirid.
18. First  - tagastab kogu esimese elemendi või esimese elemendi, mis rahuldab kriteeriumi
FirstOrDefault - sama mis “first” aga kui indeks õletab piiri siis põhilise väärtuse.
19. Last, LastOrDefault - väljastab kogu viimase väärtuse või viimase väärtuse, mis rahuldab kriteeriumi
20. Single - tagastab kogumiku ainsa elemendi (või ainsa mis rahuldab kriteeriumit) . Kui sobilikku pole siis väljastab (InvalidOperationException) 
SingleOrDefault - tagastab defauldi kui ei leita sobilikku. Kui leiab mitu sobilikku siis väljastab InvalidOperationException.
21. SequenceEquel - kontrollib kas number, väärtus ja järjekord kahes jadas on sama või ei.
22. Concat - lisab sama tüübiga jadad kokku ja väljastab uue jada
23. DefaultEmpty - väljastab uue kogu defaulti väärtusega.
24. Empty - tagastab tühja kogu
Range - genereerib kogu IEnumerable<T> tüüpi, antud hulga elementidega järjest
Repeat - sama ainult iga element sama väärtusega
25. Distinct - tagastab eristuvad väärtused kogust
26. Except - tagastab kahe jada erinevused
27. Intersect - tagastab kahe jada sarnased kohad
28. Union - väljastab kajes kogust need, mis on mälemal erised
29. Skip, SkipWhile - jätab vahele antud arvu kohtasi. Jätab vahele kuni element ei rahulda etteantud kriteeriumi.
30. Take, TakeWhile - võtab arvu elemente ja võtab elemente kuni rahuldab kriteeriumi
