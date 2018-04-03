select 
project,regexp_replace(address,'[0-9]','','g') as letters,
regexp_replace(address,'[a-zA-Z]','','g') as numbers 
from repositories 
