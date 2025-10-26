namespace ClassLibrary_gioco
{
    public class Class_Gioco
    {
        // CLASSE INIZIA IL GIOCO
        public string IniziaGioco()
        {
            return "Benvenuto nel gioco di indovinare i numeri!";
        }


        // CLASSE NUMRANDOM
        public int[] GenRandomNum()
        {
            Random numRandom = new Random();
            int[] arrNumRan = new int[10];

            // genera i numeri casuali
            for (int i = 0; i < arrNumRan.Length; i++)
            {
                arrNumRan[i] = numRandom.Next(1, 11);
            }

            return arrNumRan;
        }


        // CLASSE CONTROLLA SE I NUMERI SONO PRESENTI
        public bool ControllaNum(int[] arrNumRan, int num)
        {
            // controlla se è presente
            foreach (int n in arrNumRan)
            {
                if (n == num)
                {
                    return true;
                }
            }
            return false;
        }


        // CLASSE CHE CONTA I TENTATIVI
        public int ContaTentativi(int tentativi)
        {
            return tentativi + 1;
        }
    }
}