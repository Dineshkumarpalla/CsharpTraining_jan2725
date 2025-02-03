using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining_jan2725
{
    public class Network
    {
        public int Id { set; get; }
        public double Source { set; get; }
        public double Destination { set; get; }
        public string Date { set; get; }
        public string Time { set; get; }
        public string Status { set; get; }
        public string Netwokr { set; get; }

        public Network()
        {

        }
        public Network(int id, double source, double destination, string date, string time, string status, string network)
        {
            Id = id;
            Source = source;
            Destination = destination;
            Date = date;
            Time= time;
            Status = status;
            Netwokr = network;
        }

        
        public void ReadDateFromFile()
        {
            List<Network> list = new List<Network>();

            FileStream fs = new FileStream("C:\\Users\\Dinesh\\Downloads\\networklog.txt",FileMode.Open,FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            int id = 0; double source = 0; double destination = 0; string date = ""; string time = ""; string status = ""; string network = "";
            while(sr.Peek()>0)
            {
                string line=sr.ReadLine();
                if(line.StartsWith("Id"))
                {
                    string[] a = line.Split(":");
                    id = Convert.ToInt32(a[1]);
                }
                else if(line.StartsWith("Source"))
                {
                    string[] a = line.Split(":");
                    source = Convert.ToDouble(a[1]);
                }
                else if (line.StartsWith("Destination"))
                {
                    string[] a = line.Split(":");
                    destination = Convert.ToDouble(a[1]);
                }
                else if (line.StartsWith("Date"))
                {
                    string[] a = line.Split(":");
                    string datetimeString = a[1].Trim();
                    string[] datetimeParts = datetimeString.Split(' ');
                    date = datetimeParts[0];
                    time = datetimeParts[1];
                }
                //else if (line.StartsWith("Date"))
                //{
                //    string[] a = line.Split(":");
                //    string datetimeString = a[1];
                //    string[] datetimeParts = datetimeString.Split(' ');
                //    time = datetimeParts[1];
                //}
                else if (line.StartsWith("Status"))
                {
                    string[] a = line.Split(":");
                    status = a[1];
                }
                else if (line.StartsWith("Network"))
                {
                    string[] a = line.Split(":");
                    network = a[1];
                }

                if (id != 0 && source != 0 && destination != 0 && date != "" && time != "" && status != "" && network != "")
                {
                    Network n = new Network(id,source,destination,date,time,status,network);
                    list.Add(n);

                    id = 0;
                    source = 0;
                    destination = 0;
                    date = "";
                    time = "";
                    status = "";
                    network = "";
                }
            }

            fs.Close();
            Console.WriteLine($"Id\tSource\tDestination\tDate\tTime\tStatus\tNetwork");
            foreach(var item in list)
            {
                Console.WriteLine($"{item.Id}\t{item.Source}\t{item.Destination}\t{item.Date}\t{item.Time}\t{item.Status}\t{item.Netwokr}");
            }
        }
    }
}
