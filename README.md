# EF Core 5.0 (Many-to-Many)

Simple windows console app to show some of the ways you can use EF Core 5.0 to setup many-to-many relationships. While I believe you can do the same thing with sqllite or an in memory db, I'm using SQL Server as that's what I work with the most.

## Branches

 1. **minimal** - The simplest setup. A code first approach.
 2. **specify-linking-table-name** - Slight variation of **minimal** where we want to override EF defaults for table names.
 3. **with-linking-table-entity** - A more complex example where you want to explicitly define the linking/mapping table.

## Resources
1. TL;DR Blog Post - https://www.thereformedprogrammer.net/updating-many-to-many-relationships-in-ef-core-5-and-above/
2. Official MS Docs - https://docs.microsoft.com/en-us/ef/core/modeling/relationships?tabs=fluent-api%2Cfluent-api-simple-key%2Csimple-key#many-to-many
3. A Tour of EF Core 5.0 (Deep Dive) - https://www.youtube.com/watch?v=b2klBzcALJc
