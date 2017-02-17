SELECT Username,
       FullName 
  FROM Users
 ORDER BY LEN(CONCAT(Username,FullName)) ,BirthDate DESC