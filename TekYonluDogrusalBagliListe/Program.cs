//Göstericiler yani nextler tek yöne gidiyor headden başlıyor sona kadar gidiyor. Yani 2. düğüme gitmek istiyorsam 1den başlamak zorundayım yada 3. düğüme gitmek istiyorsam 2.den başlamak zorundayım yani 2'den bire geçme yok yani geriye gitme yok bu düğüm yapısına tek yönlü doğrusal bağlı liste deniyor.

using TekYonluDogrusalBagliListe;

Liste tyListe = new Liste();
tyListe.sonaEkle(10);
tyListe.sonaEkle(20);
tyListe.sonaEkle(30);
tyListe.arayaEkle(1, 15);
tyListe.arayaEkle(2, 17);
tyListe.aradanSil(2);
tyListe.bastanSil();
tyListe.bastanSil();
tyListe.bastanSil();
tyListe.bastanSil();
tyListe.yazdir();
Console.ReadLine();