using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConstantPhysics
{
    [Serializable]
    public class User
    {
        //Attributes
        string username;
        string password;
        int avatar;
        int currentScore;
        int time;
        int overallScore;
        int level;
        //Constrcuctors
        public User()
        {
            username = "";
            password = "";
            avatar = 0;
            currentScore = 0;
            overallScore = 0;
            time = 0;
            level = 0;
        }
        //Properties
        public string Username { get { return username; } set { username = value; } }
        public string Password { get { return password; } set { password = value; } }
        public int Avatar { get { return avatar; } set { avatar = value; } }
        public int Score { get { return currentScore; } set { currentScore = value; } }
        public int Time { get { return time; } set { time = value; } }
        public int Level { get { return level; } set { level = value; } }
        public int OverallScore { get { return overallScore; } set { overallScore = value; } }
        
    }
}
