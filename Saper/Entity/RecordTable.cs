using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace Saper.Entity
{
    [Serializable()]
    public class RecordTable
    {
        public List<Record> Records;

        public bool IsNewRecord(int time, Mode mode)
        {
            var CurrentRecord = FindCurrentRecord(mode);
            if (CurrentRecord == null)
                return false;
            return CurrentRecord.Time > time;
        }

        public Record FindCurrentRecord(Mode mode)
        {
            for (var i = 0; i < Records.Count; i++)
            {
                if (Records[i].Difficulty == mode)
                {
                    return Records[i];
                }
            }
            return null;
        }
        public void AddNewRecord(Record newRecord)
        {
            var CurrentRecord = FindCurrentRecord(newRecord.Difficulty);
            var position = Records.FindIndex(elem => elem == CurrentRecord);
            Records.Insert(position, newRecord);
            Records.Remove(CurrentRecord);
        }

        public void ToDefault()
        {
            Records = new List<Record>();
            Records.Add(Record.DefaultEasy);
            Records.Add(Record.DefaultMedium);
            Records.Add(Record.DefaultProfessional);
            WriteIntoFile();
        }

        public void ReadFromFile()
        {
            try { 
                Stream file = File.Open("RecordTable.dat", FileMode.Open);
                BinaryFormatter binFormat = new BinaryFormatter();
                RecordTable newTable = (RecordTable)binFormat.Deserialize(file);
                Records = newTable.Records;
                file.Close();
            }
            catch (Exception ex)
            {
                ToDefault();
            }
        }

        public void WriteIntoFile()
        {
            try
            {
                Stream file = File.Create("RecordTable.dat");
                BinaryFormatter binFormat = new BinaryFormatter();
                binFormat.Serialize(file, this);
                file.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        
    }
}
