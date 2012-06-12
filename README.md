About
=====
Processes the official data dump from CCP in to a format which is a little nicer for rails to consume.

Source Trees
============
Since the ruby version runs cleanly on *some* tables, but not others (this is related to TinyTDS and my local server version). I have started an implementation in C# using a native MySQL driver to perform the inserts. The ruby logic may be found in /ruby and C# in /C#.

Ruby Requirements
=================
* Local MySQL Instance (v5.0.3 or newer)
* Remote MSSQL Server Instance
* Pre-defined mysql database with the appropriate rails schema
* Pre-defined mssql server database with the CCP data loaded
* Ruby 1.9.2
* RVM

Ruby Setup
==========
```bash
brew install freetds
rvm 1.9.2@eve_migrator --create
bundle install
```

Ruby Execution
==============
**WARNING: Any tables that are being loaded will remove all current data before loading the new data. Consider commenting out classes that are "good"**

```bash
be ./process.rb
```
