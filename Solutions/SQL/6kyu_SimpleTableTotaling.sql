select 
       row_number() over(order by (sum(p.points))desc) as rank,
       regexp_replace(p.clan,'^$','[no clan specified]') as clan,
       sum(p.points) as total_points,
       count(p.name) as total_people    
from people p
group by clan
order by total_points desc
