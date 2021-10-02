with cte
as (
	select row_number() over (
			partition by path order by filename
			) rownum
		,'new ZipDir(new DirectoryInfo(@' + QUOTENAME(fullpath, '"') + ')),' csharp
		,fullpath
		,path
		,filename
	from (
		select distinct '\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\' + replace(case 
					when RIGHT(DOC_DIR, 1) <> '\'
						then DOC_DIR
					else DOC_DIR
					end, '/', '\') + (
				select top 1 DOC_FILE
				from PROPBUT29
				where DOC_DIR = P.DOC_DIR
					and DOC_FILE = p.DOC_FILE
				) fullpath
			,replace(right(case 
						when RIGHT(DOC_DIR, 1) <> '\'
							then DOC_DIR + '\'
						else DOC_DIR
						end + DOC_FILE, charindex('\', reverse(case 
								when RIGHT(DOC_DIR, 1) <> '\'
									then DOC_DIR + '\'
								else DOC_DIR
								end + DOC_FILE))), '\', '') filename
			,'\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\' + replace(case 
					when RIGHT(DOC_DIR, 1) <> '\'
						then DOC_DIR
					else DOC_DIR
					end, '/', '\') path
		from PROPBUT29 P
		) x
	)
select distinct csharp
from cte;

with cte
as (
	select row_number() over (
			partition by path order by filename
			) rownum
		,'new ZipDir(new DirectoryInfo(@' + QUOTENAME(path, '"') + ')),' csharp
		,path
		,filename
	from (
		select distinct replace(right(case 
						when RIGHT(DOC_DIR, 1) <> '\'
							then DOC_DIR + '\'
						else DOC_DIR
						end + DOC_FILE, charindex('\', reverse(case 
								when RIGHT(DOC_DIR, 1) <> '\'
									then DOC_DIR + '\'
								else DOC_DIR
								end + DOC_FILE))), '\', '') filename
			,'\\10.135.11.25\usersdefpaths\lpc military portfolio 36516\Live\' + replace(case 
					when RIGHT(DOC_DIR, 1) <> '\'
						then DOC_DIR
					else DOC_DIR
					end, '/', '\') path
		from PROPBUT29 P
		) x
	)
select REPLACE(reverse(SUBSTRING(reverse(path), 0, charindex('\', REVERSE(path), 2))), '\', '') folder
	,*
from cte
where rownum = 1
order by path
	,filename
