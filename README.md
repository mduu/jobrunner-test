# jobrunner-test
Test for a skeleton of a self-terminating job-runner using IHostedService in C#.

Run's a job that is specified by name as command line argument ``jobname`` and then terminate the application. This maybe be usefull for your own Kubernetes cron-jobs or other self-terminating console-apps that use the generic host and its features.
