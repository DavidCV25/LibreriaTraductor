namespace LibreriaTraductor;
//!#####=====ESTRUCTURA DE IDIOMAS=====#####!//
public struct Idiomas
{
    public string ingles;
    public string frances;
    public string italiano;
    public string arabe;

    public Idiomas(string i, string f, string it, string a)
    {
        this.ingles = "" + i;
        this.frances = "" + f;
        this.italiano = "" + it;
        this.arabe = "" + a;
    }

    public override string ToString()
    {
        int acolumn = 15;
        /*
        if(ingles != null && frances != null && italiano != null && arabe != null)
        {return string.Format(ingles.PadRight(acolumn) + frances.PadRight(acolumn) + italiano.PadRight(acolumn) + arabe.PadRight(acolumn));}
        else{return string.Format("No hay traducciones para esta palabra");}
        */
        return string.Format(ingles.PadRight(acolumn) + frances.PadRight(acolumn) + italiano.PadRight(acolumn) + arabe.PadRight(acolumn));
    }
}