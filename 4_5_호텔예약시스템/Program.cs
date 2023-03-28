using System;

public class HotelBookingSystem
{
    static void Main(string[] args)
    {

    }
    
    private string[] availableRooms;

    public string GuestName { get; set; }
    public string GuestPhoneNum { get; set; }
    public int BookingNum { get; set; }
    public DateTime CheckInDate { get; set; }
    public DateTime CheckOutDate { get; set; }
    public string RoomNum { get; set; }

    public HotelBookingSystem()
    {
        availableRooms = new string[] { "101", "102", "103", "201", "202", "203" };
    }

    public bool VerifyGuest()
    {
        Console.WriteLine("예약자 이름 : " + GuestName);
        Console.WriteLine("예약자 휴대폰번호 : " + GuestPhoneNum);

        return true;
    }

    public int CheckAvailableRooms()
    {
        int count = availableRooms.Length;
        Console.WriteLine("예약 가능한 객실 개수 : " + count);
        return count;
    }
}
