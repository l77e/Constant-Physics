using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace ConstantPhysics
{
    [Serializable]
    public class AllUser
    {
        public List<User> userList = new List<User>();
        public AllUser()
        {
            //nothing
        }
        public int UserCount
        {
            get { return userList.Count; }
        }
        public void AddUser(ref User newUser)
        {
            userList.Add(newUser);
        }
        public bool RemoveUser(string username)
        {
            bool removed = false;
            User thisUser;
            thisUser = userList.Find(user => user.Username == username);
            if (thisUser != null)
            {
                userList.Remove(thisUser);
                removed = true;
            }
            return removed;
        }
        public void UpdateUser(ref User thisUser)
        {
            RemoveUser(thisUser.Username);
            AddUser(ref thisUser);
        }
        public User GetUser(int index)
        {
            User thisUser = null;
            if (index >= 0 && index < userList.Count)
                thisUser = userList[index];
            return thisUser;
        }
        public User GetUser(string username)
        {
            //Returns the player object corresponding to username
            // or the value null if the user is not found
            User thisUser;
            thisUser = userList.Find(user => user.Username == username);
            return thisUser;
        }
        public bool UserExists(string username)
        {
            bool exists = false;
            User thisUser;
            thisUser = userList.Find(user => user.Username == username);
            exists = (thisUser != null);
            return exists;
        }
        //public int GetScore(string username)
        //{
        //    int score;
        //    score = userList.Find(user. => User.Username == )
        //}
        public void SortByScore()
        {
            userList.OrderBy(x => x.OverallScore);
        }
    }
        public class DataSave
        {
            public static void SaveObject(AllUser thisObject)
            {
                //filestream
                Stream sw;
                //stream format
                BinaryFormatter bf = new BinaryFormatter();
                //Make File
                sw = File.Open("userData.txt", FileMode.Create);
                //write file
                bf.Serialize(sw, thisObject);
                //stop stream
                sw.Close();
            }
            public static void LoadObject(ref AllUser thisObject)
            {
            try {
                //Make Stream
                Stream sr;
                //stream format
                BinaryFormatter bf = new BinaryFormatter();
                //open file
                sr = File.OpenRead("userData.txt");
                //read data
                thisObject = (AllUser)bf.Deserialize(sr);
                //close stream
                sr.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { }
            }

        }
    }
