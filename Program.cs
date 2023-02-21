using System.Xml.XPath;

XPathDocument XMLDokuman = new XPathDocument("Personeller.xml");
//XPathDocument, doğrudan XML dosyasını çeker.
XPathNavigator nav = XMLDokuman.CreateNavigator();
//XMLDokuman nesnesi içindeki XML dosyasının içinde gezinebilmemiz amacıyla(XPath komutlarını kullanarak) CreateNavigator metodu ile bir navigator oluşturduk.Bu sayede, XML dosyasının root elementi nedir, hangi attributlar vardır, nodelar nelerdir vs. gibi bilgiler nav XPathNavigator tipinden nav nesnesine yüklenmiş olur.Bir nevi XML dosyasının şeması elde edilmiştir.
//XPathNavigator nesnesi, XPath komutlarını kullanarak XML dosyası içinde gezinmemizi sağlayan metodlar barındırır.XPath komutlarını kullanarak XML nodelar içinde istediğimiz node dan istediğimiz node a zıplamalar yapabiliriz.
XPathNodeIterator ni = nav.Select("Personeller/Personel/Adi");
//Personeller/Personel/Adi(Bu bir XPath komutudur.)
//Personeller root elementinin içindeki Personel elementi içindeki Adi elementinde gezin anlamına gelmektedir.

while (ni.MoveNext())
{
    //MoveNext metodu ile nodeları teker teker dolaşırız.
    //ni nesnesi içindeki XPath komutu ile seçilmiş olan nodeları teker teker dolanır.
    Console.WriteLine(ni.Current.Name + " " + ni.Current.Value + " " + ni.Current.NodeType);
    //Current, o anda aktif olan node un özelliklerini verir.
}