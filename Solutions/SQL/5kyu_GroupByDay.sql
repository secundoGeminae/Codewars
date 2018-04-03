select created_at::timestamp::date as day,
       description,
       count(*)  
from events
where name = 'trained'
group by day,description
