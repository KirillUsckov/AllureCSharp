title = "A1QA Allure Report"
with open('target\\allure-report\\widgets\\summary.json','r+') as report:
   x = report.read().replace("Allure Report", title)
with open('NUnitAllureProject\\allure-report\\widgets\\summary.json','w+') as report:
    report.write(x)