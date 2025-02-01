using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Xml.Serialization;

namespace CsharpTraining_jan2725
{
    public class Transaction
    {
        public int Id { get; set; }
        public double Source { get; set; }
        public double Destination { get; set; }
        public String Date { get; set; }
        public String Status { get; set; }

        public String Network { get; set; }

        public Transaction(int id,double source,double destination,String date,String status,String network)
        {
            Id = id;
            Source = source;
            Destination = destination;
            Date = date;
            Status = status;
            Network = network;
        }

        public void CreateTransaction()
        {
            FileStream fs = new FileStream("trans.txt", FileMode.Create,FileAccess.ReadWrite);
            StreamWriter streamWriter = new StreamWriter(fs);
            streamWriter.WriteLine("Id:"+Id);
            streamWriter.WriteLine("Source:"+Source);
            streamWriter.WriteLine("Destination:" + Destination); 
            streamWriter.WriteLine("Date:"+Date);
            streamWriter.WriteLine("Status:"+Status);
            streamWriter.WriteLine("Network:"+Network);
            streamWriter.Close();
            fs.Close();
        }
        public void ReadTransaction()
        {
            List<Transaction> list = new List<Transaction>();

            FileStream fs = new FileStream("C:\\Users\\Dinesh\\Downloads\\networklog.txt", FileMode.Open,FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);


            int id = 0; double source = 0; double destination = 0; String date = ""; String status = ""; String network = "";
            while (sr.Peek() > 0)
            {
                String line = sr.ReadLine();
                if (line.StartsWith("Id"))
                {
                    String[] a = line.Split(":");
                    id = Convert.ToInt32(a[1]);
                }
                else if (line.StartsWith("Source"))
                {
                    String[] a = line.Split(":");
                    source = Convert.ToDouble(a[1]);
                }
                else if (line.StartsWith("Destination"))
                {
                    String[] a = line.Split(":");
                    destination = Convert.ToDouble(a[1]);
                }
                else if (line.StartsWith("Date"))
                {
                    String[] a = line.Split(":");
                    date = a[1];
                }
                else if (line.StartsWith("Status"))
                {
                    String[] a = line.Split(":");
                    status = a[1];
                }
                else if (line.StartsWith("Network"))
                {
                    String[] a = line.Split(":");
                    network = a[1];
                }


                if (id != 0 && source != 0 && destination != 0 && date != "" && status != "" && network != "")
                {
                    Transaction t = new Transaction(id, source, destination, date, status, network);
                    list.Add(t);

                    id = 0;
                    source = 0;
                    destination = 0;
                    date = "";
                    status = "";
                    network = "";
                }
            }
            sr.Close();
            fs.Close();
            Console.WriteLine("Id\tSouce\tDestination\tDate\tStatus\tNetwork");
            foreach (var item in list)
            {
                Console.WriteLine($"{item.Id}\t{item.Source}\t{item.Destination}\t{item.Date}\t{item.Status}\t{item.Network}");
            }
        }

    }
}
