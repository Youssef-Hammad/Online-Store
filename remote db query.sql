
delete from [USER] where USERNAME = 'admin'

insert into [USER] values ('admin','admin@doamin','p',0) 
select * from [PRODUCTSTOCK]

select u.USERNAME, u.Email, (p.QTY)
from [USER] as u, PURCHASEHISTORY as p
where u.USERNAME = p.USERNAME

select * from APPROVEDPRODUCTS

SELECT [USER].USERNAME, [USER].EMAIL, max(PURCHASEHISTORY.QTY)
                            FROM [USER], PURCHASEHISTORY
                            WHERE [USER].USERNAME = [PURCHASEHISTORY].USERNAME
							GROUP BY [USER].USERNAME, [USER].EMAIL;

SELECT a.PRODUCTNAME, a.PRODUCTPRICE, a.PRODUCTCAT,  avg(p.QTY)
FROM APPROVEDPRODUCTS AS a, PURCHASEHISTORY AS p
WHERE a.PID = p.PID
GROUP BY a.PRODUCTNAME, a.PRODUCTPRICE, a.PRODUCTCAT;

select * from [USER] 
select OWNERUSR, STORENAME 
from STORES as s, [USER] as u
where u.USERNAME = s.OWNERUSR and u.USERNAME = 'merchant'