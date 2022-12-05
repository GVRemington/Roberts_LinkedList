using Roberts_LinkedList;

/*
 Roberts, Rayleen
 IT 113
 Notes: I put this up but the console just looks at me, I even went 
        back and erased my Add method and followed along with your tutorial
        and it still just looks at me.  I ran the breakpoints and it LOOKS
        like its putting the info in...and it looks just like yours, but 
        it STILL JUST LOOKS AT ME!!!! I've beat my head on the wall for 2 weeks!!
 Behaviors Not Implemented and Why:  Print maybe? Maybe all of them, Maybe None!
                                     I have ZERO IDEA! Also, I didn't do anything 
                                     as far as accepting user input because I can't
                                     can't get past this place. */
 
LinkedList list = new LinkedList();


list.Add("Theresa");
list.Add("Bob");
list.Add("Larry");
list.Add("Fred");

Console.WriteLine(list.Print());

list.Remove("Larry");

Console.WriteLine(list.Print());

Console.WriteLine(list.Contains("Fred"));





