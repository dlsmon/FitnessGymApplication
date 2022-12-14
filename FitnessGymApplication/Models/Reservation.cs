using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessGymApplication.Models
{
    //A Resevation is created for a session that will happen at given 
    //One client can make many resevations
    //A Reservation can have many clients. Up to maxParticipants.
    public class Reservation
    {
        public int Id { get; set; }

        //Maximum participants possible during a session reservation.
        public int MaxParticipants { get; set; }

        //Cancelled is like a boolean.
        //Reservation was created by client. By Default = 0 
        //Reservation was cancelled by client before the session date= 1 
        //Reservation was created by client but the client didn't participate = 2.
        public int Cancelled { get; set; }
        public int IdSession { get; set; }
        public int IdClient { get; set; }

        //Foreign KEYS
        [ForeignKey("IdSession")]
        public virtual Session? Session { get; set; }

        [ForeignKey("IdClient")]
        public virtual Client? Client { get; set; }
    }
}
