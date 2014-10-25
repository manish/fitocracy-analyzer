Fitocracy Analyzer
===================

Fitocracy, a popular fitness social network does not provide its developers an API. This means that if you have been using Fitocracy for a while, all your data is locked down and you can't export it.

As of now for exporting data, you can download the png and cvs for each activity which can become really cumbersome and manual.

As of now exporters exists, but they use `https://www.fitocracy.com/get_history_json_from_activity`
API call, which returns undocumented JSON.

This repository contains a bunch of tools for exporting your Fitocracy data and then analyzing the exported data.


## Technologies Used

As of now the tool is written using `C#` and opens in `MonoDevelop` on `OSX`. It runs only on OSX as of now and the support for other platforms will arrive later.

The tool assumes that you have Firefox installed at a standard location in `/Applications/Firefox.app/`

The Web automation is taken care by Selenium and its C# driver.