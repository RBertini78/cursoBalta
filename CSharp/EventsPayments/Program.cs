namespace EventsPayments;

class Program
{
    static void Main(string[] args)
    {
        var room = new Room(10);
        room.RoomFullEvent += OnRoomFull;
        room.ReserveSeat();
        room.ReserveSeat();
        room.ReserveSeat();
        room.ReserveSeat();
        room.ReserveSeat();
        room.ReserveSeat();
        room.ReserveSeat();
        room.ReserveSeat();
        room.ReserveSeat();
        room.ReserveSeat();
        room.ReserveSeat();
        room.ReserveSeat();
    }
    
    static void OnRoomFull(object sender, EventArgs e)
    {
        Console.WriteLine("Room is full");
    }
    public class Room{
        public Room(int seats)
        {
            Seats = seats;
            seatsInUse = 0;
        }

        private int seatsInUse = 0;
        public int Seats { get; set; }

        public void ReserveSeat()
        {
            seatsInUse++;
            if(seatsInUse > Seats)
            {
                OnRoomFull(EventArgs.Empty);
            } else {
                Console.WriteLine("Seat reserved");
            }
        }

        public event EventHandler RoomFullEvent;

        protected virtual void OnRoomFull(EventArgs e)
        {
            EventHandler handler = RoomFullEvent;
            handler?.Invoke(this, e);
        }
        public event EventHandler RoomAvailable;
    }
}
