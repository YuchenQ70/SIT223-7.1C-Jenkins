pipeline {
    agent any

    stages {
        stage('Build') {
            steps {
                echo 'Stage 1: Build'
                echo 'Task: Compile and package the application code.'
                echo 'Tool: Maven can be used as the build automation tool.'
            }
        }

        stage('Unit and Integration Tests') {
            steps {
                echo 'Stage 2: Unit and Integration Tests'
                echo 'Task: Run unit tests to check code functions and run integration tests to check components work together.'
                echo 'Tool: JUnit can be used for unit testing, and Selenium can be used for integration testing.'
            }
        }

        stage('Code Analysis') {
            steps {
                echo 'Stage 3: Code Analysis'
                echo 'Task: Analyse the source code and check code quality standards.'
                echo 'Tool: SonarQube or SonarCloud can be used for code analysis.'
            }
        }

        stage('Security Scan') {
            steps {
                echo 'Stage 4: Security Scan'
                echo 'Task: Scan the code and dependencies to find possible security vulnerabilities.'
                echo 'Tool: OWASP Dependency-Check or Snyk can be used for security scanning.'
            }
        }

        stage('Deploy to Staging') {
            steps {
                echo 'Stage 5: Deploy to Staging'
                echo 'Task: Deploy the application to a staging environment for testing.'
                echo 'Tool: AWS EC2 can be used as the staging server.'
            }
        }

        stage('Integration Tests on Staging') {
            steps {
                echo 'Stage 6: Integration Tests on Staging'
                echo 'Task: Run integration tests in the staging environment to check production-like behaviour.'
                echo 'Tool: Postman or Selenium can be used for staging integration testing.'
            }
        }

        stage('Deploy to Production') {
            steps {
                echo 'Stage 7: Deploy to Production'
                echo 'Task: Deploy the tested application to the production environment.'
                echo 'Tool: AWS EC2 can be used as the production server.'
            }
        }
    }
}
