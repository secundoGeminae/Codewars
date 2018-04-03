select * from departments
where exists 
(select id,name from sales where price >98.00)
