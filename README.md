# BlankMP3TagFinder
Quick and dirty app to find mp3s with blank album, artist, title and comment tags


I got a new DAP for christmas(Xduoo x10). Its kind of buggy doesn't like mp3s with completely blank tags. I made a quick app to sweep through directories and locate mp3s with blank artist, comment, title and album tags. The app will display the path to each file it finds. It also has a feature to add a blank space the comment tag of each file it finds and saves it.

I'm also learning about async and threading functionality in C# so this seemed like a pretty good way to exercise. 


This app requires the TagLib-Sharp Library found here; https://github.com/mono/taglib-sharp
