select p.id,
       p.name,
       count(s.sale) as sale_count,
       rank() over(partition by(p.name) order by(p.id)) as sale_rank 
from people p join sales s on p.id=s.people_id 
group by(p.id) 
