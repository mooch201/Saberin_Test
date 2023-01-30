# Saberin_Test

You should be able to just download the solution and run it.

I added a contacts view to menu

Normally I would not handle the db context like this and would probably create a dbFactory of some type. 
I did not add all the crud functionality as it was out of scope, although if i added the context properly it would have scafolded right in.

I did not use telerik or kendo to populate the table I just did a very basic loop in the page.



You might need to install the inmemory nuget package microsoft.entityframeworkcore.inmemory
I had some issues with scafolding the razor page I created, and the fix was lowering the version for the code  web.codegeneration.design to 5.0.2


