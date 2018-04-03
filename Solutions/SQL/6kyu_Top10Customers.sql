select c.customer_id,
c.email, 
count(p.amount) as payments_count,
sum(p.amount :: float(8)) as total_amount 
from customer c 
join payment p
on c.customer_id= p.customer_id 
group by(c.customer_id) 
order by(sum(p.amount)) desc
limit 10
