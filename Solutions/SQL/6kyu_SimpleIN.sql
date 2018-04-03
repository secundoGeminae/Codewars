select d.id,d.name 
from departments d 
where id in (select department_id from sales s where s.price >98 )
