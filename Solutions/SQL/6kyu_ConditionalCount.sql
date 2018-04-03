select EXTRACT(month FROM payment_date) as month,
       count(payment_id) as total_count,
       sum(amount) as total_amount,
       count(payment_id) filter (where staff_id = '1') as mike_count,
       sum(amount) filter (where staff_id = '1') as mike_amount,
       count(payment_id) filter (where staff_id = '2') as jon_count,
       sum(amount) filter (where staff_id = '2') as jon_amount       
from payment group by(month) order by month
