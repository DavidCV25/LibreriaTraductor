namespace LibreriaTraductor;
public class Traductor
{
    private Dictionary<string, Idiomas> _dic;
    
    //!#####=====CONSTRUCTOR=====#####!//
    
    public Traductor()
    {
        _dic = new();
        /*
        Idiomas NoEncontrado = new Idiomas();
        string clave = "NoEncontrado";
        NoEncontrado.ingles = "";
        NoEncontrado.arabe = "";
        NoEncontrado.italiano = "";
        NoEncontrado.frances = "";
        */
    }

    //!#####=====TRADUCIR=====#####!//

    public Idiomas Traducir(string palabra)
    {
        Idiomas traduccion;
        if(_dic.TryGetValue(palabra, out traduccion))
        {return traduccion;}
        return new Idiomas("","","","");
    }

    public bool Traducir2(string palabra, out Idiomas traduccion)
    {
        return _dic.TryGetValue(palabra, out traduccion);
    }

    //!#####=====AÑADIR=====#####!//

    public bool Anadir(string palabra, Idiomas i)
    {
        if (!_dic.ContainsKey(palabra))
        {
            _dic.Add(palabra, i);
            return true;
        }
        else { return false; }
    }

    //!#####=====MODIFICAR=====#####!//

    public bool Modificar(string palabra, Idiomas i)
    {

        if (!_dic.ContainsKey(palabra))
        {
            _dic[palabra] = i;
            return true;
        }
        else { return false; }
    }

    //!#####=====ELIMINAR=====#####!//

    public bool Eliminar(string palabra)
    {
        return _dic.Remove(palabra);
    }

    //!#####=====TOSTRING=====#####!//

    public override string ToString()
    {
        int acolumn = 15;
        string cadena = "Español".PadRight(acolumn) + "ingles".PadRight(acolumn) + "Francés".PadRight(acolumn) + "Italiano".PadRight(acolumn) + "Árabe".PadRight(acolumn);
        cadena += "\n" + new string('=', acolumn * 5);

        foreach (KeyValuePair<string, Idiomas> tmp in _dic)
        {cadena += "\n" + tmp.Key.PadRight(acolumn) + tmp.Value;}
        return string.Format(cadena + "\n");
    }
}