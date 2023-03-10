// See https://aka.ms/new-console-template for more information

using System.IO;
using System.Linq;
using System;
using System.Text;
using System.Runtime.InteropServices;
using static System.Console;
using System.Globalization;
using static System.String;
using System.Net.NetworkInformation;
//using static System.Runtime.InteropServices.JavaScript.JSType;

////////////////////////////////////////MAIN/////////////////////////////////////////////////

string filename = "C:\\Users\\des808\\source\\repos\\text_reader\\text_reader\\log_mini.txt";
int koll_vo = 1;
int objekt = 100;
Reader rider = new Reader();//= new (filename, koll_vo);
//Write("Введите колличество строк: ");koll_vo = Convert.ToInt32(ReadLine());rider.read_file(filename, koll_vo);
//Write("Введите номер строки: "); koll_vo = Convert.ToInt32(ReadLine()); rider.read_file_str(filename, 688338);
Write("Введите номер обьекта: "); objekt = Convert.ToInt32(ReadLine()); rider.read_file_n_object(filename, objekt);   
//rider.read_all_file(filename); 


///////////////////////////////////////END_MAIN////////////////////////////////////////////// 

class Parser 
{
    int date_d;
    int date_m;
    int date_g;
    int time_h;
    int time_m;
    int time_s;
    int time_ms;
    string sentinel;
    int senti_chanel;
    string r_chanel_str;
    int chanel;
    string counter_str;
    int counter;
    string format_str;
    int format;
    string codirovka;
    int N_obekta;
    string Sirena_vkl_vikl;
    string snyat_postavlen;
    string sobytie;
    string poyasn_sobytiya;
    string polzovatel_str;
    int polzovatel;
    string telephone;
    int telephone_chanel;
    string telephone_error;
    string comm;
    int comm_chanel;
    string comm_error;
    public int length_arr;
    string error;
    public int N_object
    {
        get { return this.N_obekta; }
    }
public int parser(string str,long n_stroki) 
    {
        string[] arr_string = str.Split(new char[] { ' ', '/', ':', '.' }, StringSplitOptions.RemoveEmptyEntries);
        /*
        for (int x = 0; x < arr_string.Length; x++) { 
            if (x != arr_string.Length - 1) { Write($"{arr_string[x]}, ");}
            else{ WriteLine($"{arr_string[x]}"); } }
        WriteLine();
        */
        length_arr = arr_string.Length;
        /*
         Console.ForegroundColor = ConsoleColor.DarkRed; // устанавливаем цвет
        //Console.ResetColor(); // сбрасываем в стандартный
        Console.WriteLine($"Строка №: {n_stroki}. Длинна строки: {length_arr}");
        Console.ForegroundColor = ConsoleColor.Green; // устанавливаем цвет
        */
        this.date_d = Convert.ToInt32(arr_string[0]);
        this.date_m = Convert.ToInt32(arr_string[1]);
        this.date_g = Convert.ToInt32(arr_string[2]);
        this.time_h = Convert.ToInt32(arr_string[3]);
        this.time_m = Convert.ToInt32(arr_string[4]);
        this.time_s = Convert.ToInt32(arr_string[5]);
        this.time_ms= Convert.ToInt32(arr_string[6]);
        if (length_arr != 17)
        {
            this.sentinel = arr_string[7];
            this.senti_chanel = Convert.ToInt32(arr_string[8]);
        }
        int n;
        if (length_arr == 25) { 
            n = 1;
            this.r_chanel_str = arr_string[9]+" "+ arr_string[10];
            this.chanel = Convert.ToInt32(arr_string[11]);
            this.counter_str = arr_string[12];
            this.counter = Convert.ToInt32(arr_string[13]);
            this.format_str = arr_string[14];
            this.format = Convert.ToInt32(arr_string[15]);
            this.codirovka = arr_string[16];
            this.N_obekta = Convert.ToInt32(arr_string[17]);
            this.Sirena_vkl_vikl = arr_string[18]+" "+ arr_string[19]; ;
            this.snyat_postavlen = arr_string[20]; 
            this.sobytie = arr_string[21];
            this.poyasn_sobytiya = arr_string[22]+" "+arr_string[23]+" "+arr_string[24];
            return n;
        }
        if (length_arr == 22)
        {
            n = 2;
            this.r_chanel_str = arr_string[9] + " " + arr_string[10];
            this.chanel = Convert.ToInt32(arr_string[11]);
            this.counter_str = arr_string[12];
            this.counter = Convert.ToInt32(arr_string[13]);
            this.format_str = arr_string[14];
            this.format = Convert.ToInt32(arr_string[15]);
            this.codirovka = arr_string[16];
            this.N_obekta = Convert.ToInt32(arr_string[17]);
            this.Sirena_vkl_vikl = arr_string[18] + " " + arr_string[19]; ;
            this.snyat_postavlen = arr_string[20];
            this.sobytie = arr_string[21];
            return n;
        }
        if (length_arr == 23)
        {
            n = 3;
            this.r_chanel_str = arr_string[9] + " " + arr_string[10];
            this.chanel = Convert.ToInt32(arr_string[11]);
            this.counter_str = arr_string[12];
            this.counter = Convert.ToInt32(arr_string[13]);
            this.format_str = arr_string[14];
            this.format = Convert.ToInt32(arr_string[15]);
            this.codirovka = arr_string[16];
            this.N_obekta = Convert.ToInt32(arr_string[17]);
            this.Sirena_vkl_vikl = arr_string[18] + " " + arr_string[19]; ;
            this.snyat_postavlen = arr_string[20];
            this.sobytie = arr_string[21]+" "+arr_string[22];
            return n;
        }
        if (length_arr == 26)
        {
            n = 4;
            this.r_chanel_str = arr_string[9] + " " + arr_string[10];
            this.chanel = Convert.ToInt32(arr_string[11]);
            this.counter_str = arr_string[12];
            this.counter = Convert.ToInt32(arr_string[13]);
            this.format_str = arr_string[14];
            this.format = Convert.ToInt32(arr_string[15]);
            this.codirovka = arr_string[16];
            this.N_obekta = Convert.ToInt32(arr_string[17]);
            this.Sirena_vkl_vikl = arr_string[18] + " " + arr_string[19]; ;
            this.snyat_postavlen = arr_string[20];
            this.sobytie = arr_string[21];
            return n;
        }
        if (length_arr == 27)
        {
            this.r_chanel_str = arr_string[9] + " " + arr_string[10];
            this.chanel = Convert.ToInt32(arr_string[11]);
            this.counter_str = arr_string[12];
            this.counter = Convert.ToInt32(arr_string[13]);
            this.format_str = arr_string[14];
            this.format = Convert.ToInt32(arr_string[15]);
            this.codirovka = arr_string[16];
            this.N_obekta = Convert.ToInt32(arr_string[17]);
            this.Sirena_vkl_vikl = arr_string[18] + " " + arr_string[19]; ;
            this.snyat_postavlen = arr_string[20];
            this.sobytie = arr_string[21];
            
            int number;
            if (int.TryParse(arr_string[26], out number)) {
                n = 5;
                this.poyasn_sobytiya = arr_string[22] + " " + arr_string[23] + " " + arr_string[24];
                this.polzovatel_str = arr_string[25];
                this.polzovatel = Convert.ToInt32(arr_string[26]);}
            else { n = 6; this.poyasn_sobytiya = arr_string[22] + " " + arr_string[23] + " " + arr_string[24] + " " + arr_string[25] + " " + arr_string[26]; }
            return n;
        }
        if (length_arr == 13)
        {
            n = 7;
            this.telephone = arr_string[9] + " " + arr_string[10];
            this.telephone_chanel = Convert.ToInt32(arr_string[11]);
            this.telephone_error = arr_string[12];
            return n;
        }
        if (length_arr == 10)
        {
            n = 8;
            this.comm = arr_string[7];
            this.comm_chanel = Convert.ToInt32(arr_string[8]);
            this.comm_error = arr_string[9];
            return n;
        }
        if (length_arr == 17)
        {
            n = 9;
            this.error = arr_string[7]+" "+ arr_string[8] + " " + arr_string[9] + " " + arr_string[10] + " " + arr_string[11] + " " + arr_string[12] + " " + arr_string[13] + " " + arr_string[14] + " " + arr_string[15] + " " + arr_string[16];
            return n;
        }
        return 0;   
        }
    public void Print(int n)
    {
        Write($"{date_d}/{date_m}/{date_g}" +
                $" {time_h}:{time_m}:{time_s}.{time_ms}");
                
       switch (n) {
        case 1://25
        WriteLine($" {sentinel} {senti_chanel}"+ 
                $" {r_chanel_str} {chanel}"+
                $" {counter_str} {counter}"+
                $" {format_str} {format}"+
                $" {codirovka} {N_obekta}"+
                $" {Sirena_vkl_vikl} {snyat_postavlen}"+ 
                $" {sobytie} {poyasn_sobytiya}");
                break;
        case 2://22
        WriteLine($" {sentinel} {senti_chanel}" +
                $" {r_chanel_str} {chanel}" +
                $" {counter_str} {counter}" +
                $" {format_str} {format}" +
                $" {codirovka} {N_obekta}" +
                $" {Sirena_vkl_vikl} {snyat_postavlen}" +
                $" {sobytie}");
                break;
        case 3://23
        WriteLine($" {sentinel} {senti_chanel}" +
                $" {r_chanel_str} {chanel}" +
                $" {counter_str} {counter}" +
                $" {format_str} {format}" +
                $" {codirovka} {N_obekta}" +
                $" {Sirena_vkl_vikl} {snyat_postavlen}" +
                $" {sobytie}");
                break;
        case 4://26
        WriteLine($" {sentinel} {senti_chanel}" +
                $" {r_chanel_str} {chanel}" +
                $" {counter_str} {counter}" +
                $" {format_str} {format}" +
                $" {codirovka} {N_obekta}" +
                $" {Sirena_vkl_vikl} {snyat_postavlen}" +
                $" {sobytie}");
                break;
        case 5://27 int
        WriteLine($" {sentinel} {senti_chanel}" +
                $" {r_chanel_str} {chanel}" +
                $" {counter_str} {counter}" +
                $" {format_str} {format}" +
                $" {codirovka} {N_obekta}" +
                $" {Sirena_vkl_vikl} {snyat_postavlen}" +
                $" {sobytie} {poyasn_sobytiya}" +
                $" {polzovatel_str} {polzovatel}");
                break;
        case 6://27 string
        WriteLine($" {sentinel} {senti_chanel}" +
                $" {r_chanel_str} {chanel}" +
                $" {counter_str} {counter}" +
                $" {format_str} {format}" +
                $" {codirovka} {N_obekta}" +
                $" {Sirena_vkl_vikl} {snyat_postavlen}" +
                $" {sobytie} {poyasn_sobytiya}");
                break;
        case 7://13
        WriteLine($" {telephone} {telephone_chanel}" +
                $" {telephone_error}");
                break;
        case 8://10
        WriteLine($" {comm} {comm_chanel}" +
                        $" {comm_error}");
                break;
        case 9://17
        WriteLine($" {error} ");
                break;
        }
        
    }
};

class Reader:Parser
{
    string Path = "";
    int tmp = 1;
    public long counter = 0;
    /*public Reader() { }
    public Reader(string Path, int tmp) {
        this.Path = Path;
        this.tmp = tmp;
    }*/
    public void read_file(string Path,int tmp)
    {
        try
        {
            string? line;
            /*//Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);//без этой строчки не работает
            // var sr = new StreamReader(filename, Encoding.Default);// для чтения файла в ANSI-кодировке (Windows-1251 aka CP1251 в русскоязычной винде).
            //var sr = new StreamReader(filename, Encoding.GetEncoding(1251));// для чтения файла в той же кодировке Windows-1251, любая винда.
            //var sr = new StreamReader(filename, Encoding.GetEncoding(866));//для чтения файла в OEM-кодировке (DOS, CP-866), любая винда.*/
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            StreamReader sr = new StreamReader(Path, Encoding.GetEncoding(1251));//StreamReader sr = new StreamReader(filename);
            int count = 0;
            /*//line = sr.ReadLine();
            //while (line != null)//для чтения всего файла*/
            while (count != tmp)//читаем какую-то часть строк в файле
            {
                counter++;
                line = sr.ReadLine();
                Print(parser(line,counter));
                count++;
            }
            sr.Close();//close the file
            Console.ReadLine();
        }
        catch (Exception e){Console.WriteLine("Exception: " + e.Message);}
        finally{ Console.WriteLine(); Console.WriteLine("Executing finally block.");}
    }
    public void read_file_str(string Path,int N_str)
    {
        try
        {
            string? line;
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            var sr = new StreamReader(Path, Encoding.GetEncoding(1251));//StreamReader sr = new StreamReader(filename);
            line = sr.ReadLine();
            while (line != null)//для чтения всего файла
            {
                counter++; 
                if (counter == N_str) { 
                    Print(parser(line, counter));break; }
                line = sr.ReadLine();
            }
            sr.Close();//close the file
            Console.ReadLine();
        }
        catch (Exception e)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine($"Длинна строки: { length_arr} Exception:  + {e.Message}");
            Console.WriteLine($"tmp = {tmp}");
            //Console.ForegroundColor = ConsoleColor.DarkRed; // устанавливаем цвет//Console.ResetColor(); // сбрасываем в стандартный
            Console.WriteLine($"Строка №: {counter}. Длинна строки: {length_arr}");
            Console.ForegroundColor = ConsoleColor.Green;// устанавливаем цвет
        }
        finally { Console.WriteLine(); Console.WriteLine("Executing finally block."); }
    }

    public void read_file_n_object(string Path, long n_obj)
    {
        try
        {
            string? line;
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            var sr = new StreamReader(Path, Encoding.GetEncoding(1251));//StreamReader sr = new StreamReader(filename);
            line = sr.ReadLine();
            while (line != null)//для чтения всего файла
            {
                counter++;
                int tmp = parser(line, counter);
                if (n_obj==N_object) { Print(tmp); }
                line = sr.ReadLine();
            }
            sr.Close();//close the file
            Console.ReadLine();
        }
        catch (Exception e) { 
            Console.ForegroundColor = ConsoleColor.DarkRed;  Console.WriteLine("Exception: " + e.Message); 
            Console.WriteLine($"tmp = {tmp}");
            //Console.ForegroundColor = ConsoleColor.DarkRed; // устанавливаем цвет//Console.ResetColor(); // сбрасываем в стандартный
            Console.WriteLine($"Строка №: {counter}. Длинна строки: {length_arr}");
            Console.ForegroundColor = ConsoleColor.Green;// устанавливаем цвет

        }
        finally { Console.WriteLine(); Console.WriteLine("Executing finally block."); }
    } 
    public void read_all_file(string Path) 
    { 

        try
        {
            string? line;
            List<string> logs = new List<string>();
            /*//Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);//без этой строчки не работает 
            // var sr = new StreamReader(filename, Encoding.Default);// для чтения файла в ANSI-кодировке (Windows-1251 aka CP1251 в русскоязычной винде).
            //var sr = new StreamReader(filename, Encoding.GetEncoding(1251));// для чтения файла в той же кодировке Windows-1251, любая винда.
            //var sr = new StreamReader(filename, Encoding.GetEncoding(866));//для чтения файла в OEM-кодировке (DOS, CP-866), любая винда.*/
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            StreamReader sr = new StreamReader(Path, Encoding.GetEncoding(1251));//StreamReader sr = new StreamReader(filename);
            line = sr.ReadLine(); 
            while (line != null)//для чтения всего файла
            {
                //parser(line);
                //Print();
                //logs.Add(line);
                logs.Add(sr.ReadLine());
                //line = sr.ReadLine();
            }
            foreach(var x in logs) {WriteLine(x);}
            sr.Close();//close the file
            Console.ReadLine();
        }
        catch (Exception e) { Console.WriteLine("Exception: " + e.Message); }
        finally { Console.WriteLine(); Console.WriteLine("Executing finally block."); }
    }

};