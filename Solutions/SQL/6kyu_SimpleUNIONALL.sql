select 'US' as location,*
from ussales where(price >50.00) 
union all 
select 'EU' as location,*
from eusales where(price >50.00) 
