using Uppgift1;

public class Generator1
{



	public static string Tshirts()
	{
		int pris = Artikel.Pris();
		string motiv = Artikel.Motiv();
		int snittBetyg = Artikel.SnittBetyg();
		string storlek = Tshirt.Storlek();

		string Pris = " Tshirt price is:" + pris;
		string Motiv = "Motiv:" + motiv;
		string SnittBetyg = "SnittBetyg:" + snittBetyg;
		string Storlek = "Storlek:" + storlek;
		string Final = $"{Pris}\n {Motiv}\n {SnittBetyg}\n {Storlek}\n";

			return Final;
	}

	public static string CupGenerator()
	{
		int pris = Artikel.Pris();
        string motiv = Artikel.Motiv();
        int snittBetyg = Artikel.SnittBetyg();
		string typavmugg = Cups.TypAvMugg();

        string Pris = " Cup price is:" + pris;
        string Motiv = "Motiv:" + motiv;
        string SnittBetyg = "Rating:" + snittBetyg;
        string TypAvMugg = "Type:" + typavmugg;
        string Final = $"{Pris}\n {Motiv}\n {SnittBetyg}\n {TypAvMugg}\n";

		return Final;

    }

}
