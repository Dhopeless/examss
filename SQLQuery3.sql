SELECT s.Name, g.GroupName, 800 = (800 * 0.3) AS Stipend
FROM students s
JOIN OcenkaExam sr ON s.StudentID = sr.StudentID
JOIN Groups g ON s.ID = g.ID
WHERE s.StudentID IN (SELECT StudentID FROM OcenkaExam WHERE NOT results = '5')
GROUP BY s.Name, 