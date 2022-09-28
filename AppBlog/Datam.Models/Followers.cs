using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datam.Models
{
    public class Followers
    {

        public int Writerid { get; set; } // followerId
        public int FollowerId { get; set; } //FolloweeId
        public Writer Follower { get; set; }// Follower
        public Writer Writerim { get; set; }//Followee
    }
}
