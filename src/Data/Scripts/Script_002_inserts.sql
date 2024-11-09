INSERT INTO Polls(id, name)
VALUES
('4a3a8e37-bd77-4266-aaee-de276f6b85e0', 'Favorite Programming Language'),
('0c3c5fef-b022-45af-b1d2-2d9792dfcec8', 'Best Framework')


INSERT INTO Votes(Id, pollId, voterEmail, option)
VALUES
('a5be0528-1082b-4794-ae53-ec6b2b1fdb94', '4a3a8e37-bd77-4266-aaee-de276f6b85e0', 'froddo.baggins@middle-earth.com','bcec534b-ee13-4048-9298-82bbeae07aeb')

INSERT INTO Options(id, name, votes)
VALUES
('bcec534b-ee13-4048-9298-82bbeae07aeb', 'C#', 0),
('6c6ae333-0665-4df3-b95a-bcb8b3d50a35', 'JavaScript', 0)
