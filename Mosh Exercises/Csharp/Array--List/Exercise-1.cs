/*
1- When you post a message on Facebook, depending on the number of people who like your post, 
Facebook displays different information.

If no one likes your post, it doesn't display anything.
If only one person likes your post, it displays: [Friend's Name] likes your post.
If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
If more than two people like your post, 
it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.
Write a program and continuously ask the user to enter different names, until the user presses Enter 
(without supplying a name). 
Depending on the number of names provided, display a message based on the above pattern.
*/

using System;
using System.Collections.Generic;

namespace Exercise_1
{
    class FacbookLike
    {
        static void Main(string[] args)
        {
            var nameList = new List<string>();
            do
            {
                Console.Write("Enter a name: ");
                var name = Console.ReadLine();
                if (name == "")
                {
                    break;
                }
                nameList.Add(name);
            } while (true);

            string msg1 = "likes your post", msg2 = "like your post";
            var likes = nameList.Count == 0 ? "" : nameList.Count == 1 ? $"{nameList[0]} {msg1}" :
                        nameList.Count == 2 ? $"{nameList[0]} and {nameList[1]} {msg2}" :
                        $"{nameList[0]}, {nameList[1]} and {nameList.Count - 2} others {msg2}";

            Console.WriteLine(likes);
        }
    }
}