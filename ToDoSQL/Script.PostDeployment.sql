IF NOT EXISTS (select 1 from dbo.[ToDo])
begin
INSERT INTO dbo.[ToDo] ([Title], [Description])
VALUES ('Example', 'This is example');
end
