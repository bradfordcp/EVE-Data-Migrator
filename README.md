About
=====
Processes the official data dump from CCP in to a format which is a little nicer for rails to consume.

Requirements
============
* Local MySQL Instance (v5.0.3 or newer)
* Remote MSSQL Server Instance
* Pre-defined mysql database with the appropriate rails schema
* Pre-defined mssql server database with the CCP data loaded
* Ruby 1.9.2
* RVM

Setup
=====
```bash
brew install freetds
rvm 1.9.2@eve_migrator --create
bundle install
```

Execution
=========
**WARNING: Any tables that are being loaded will remove all current data before loading the new data**

```bash
be ./process.rb
```
