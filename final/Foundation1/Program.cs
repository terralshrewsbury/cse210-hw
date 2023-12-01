using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        //made up videos
        Video video1 = new Video("3 Simple Projects for Better Kitchen Storage", "Fix This Build That", 854);
        video1.AddComments("RWAllen-jx8gi", "Just a tip for pots and pan lids: Sometimes you can invert them on the pot/pan, and keep the right lid with the right pot.  And in some cases, store smaller pots or pans on the lid.");
        video1.AddComments("txag007", "Instead of the 2x4 at the back of the drawer, you could extend the sides of your organizer and have that be the stop.  Then you have 1 extra area for a larger item like a long lighter!");
        video1.AddComments("keeper6101", "1st project:  Love the additional shelves.  When I get my tiny house built, I'm going to ask for extra shelf leaves.  2nd project:  Ingenious to have a pull out tray and added shelves on the tray.  The lid holder on the door is awesome.  I have my lids all jumbled together and your idea is much better");
        video1.AddComments("Jewels5241", "Oh my goodness I love these projects! That pull out shelf add-on is GENIUS! My husband and I are about to purchase our first home and I’m totally going save these ideas! I currently use command hooks to hold my pot lids because I’m in a rental but I absolutely love the wooden holder also don’t have to worry about the plastic hooks breaking after some time. Great video! New subscriber!");

        Video video2 = new Video("Beginner's guide to Kitchen Organization (Fridge, Pantry, Knives, Pots + more)", "Ethan Chlebowski", 635);
        video2.AddComments("@marcellkovacs", "This is probably the most attainable kitchen setup I've seen so far on YouTube. Has all the things necessary and not more");
        video2.AddComments("@buttonmstr", "I went onto Amazon to add a few of these items to my wedding registry. When I added the magnetic spice rack it popped up the window that said, 'Customers who bought this item also bought these items.' It showed everything else on his list. Apparently a lot of people went on a mini shopping spree after this video.");
        video2.AddComments("@mdogg95", "How to organize the kitchen:  kick out your roommate who doesn't give a second thought about where anything goes and live by yourself.");
        video2.AddComments("@djfanatiic", "Very jealous of this setup. Living with 4 other family members who couldn’t care less about this has been tough to live with");

        Video video3 = new Video("10 kitchen products that will optimize your life.","Pro Home Cooks", 947);
        video3.AddComments("@Sib666", "Tip for people with a kitchen renovation coming up who hate dish racks on the counter: look into finnish dish drying cabinets. Finnish people have a cabinet above the sink that has built in drying racks in it so all of your drying stays neat and hidden and drips right into the sink, mold and mess free.");
        video3.AddComments("@mountainlife9427","One more Rob: NO metal canning lids! Amazon, Ball and others sell perfect seal white plastic lids. So much better for storage. Write contents on the plastic lid with permanent marker, then spray with alcolol (from your under-sink storage) to wipe the lid clean for the next product. Lids are fine in the dishwasher. They don't rust. You don't have to wrangle the two-piece version. You're welcome.  And thank you for terrific videos🥰");
        video3.AddComments("@franciet99", "Love the organizational ideas. I’d add one to the under the sink area. I would line the bottom of this area with a cabinet liner. If there is ever water issues, it might save the cabinet from water damage.");
        video3.AddComments("@maxs6026", "Always threaded the pot/pan handle through a fllipped-up lid and slid it down, then hung. Then each pot/pan is stored with its matching lid.  Works for handle style, not knobs or casserole lids. For those you can still store them upside-down on the dish/pot so they don't stick up, then you can stack stuff on top");
    
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach(var video in videos)
        {
            video.DisplayVideoInfo();
        }

    }
}
