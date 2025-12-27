SELECT s.Name, g.GroupName
FROM dbo.students s
JOIN results sr ON s.StudentID = sr.StudentID
JOIN groups g ON s.GroupID = g.GroupID
where s.StudentID IN (SELECT StudentID FROM results WHERE NOT OcenkaExam = '5')
GROUP BY s.Name, g.GroupName
HAVING COUNT(DISTINCT OcenkaExam) = 1 and min(OcenkaExam)='5'