select created_at::timestamp::date as date,
       count(title) as count, 
       sum(count(title)::int) OVER (ORDER BY created_at::timestamp::date)  AS total
from posts 
group by date
order by date
