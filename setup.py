import shutil
import subprocess
subprocess.run(['git', 'submodule', 'update', '--init'])
shutil.copytree('setup', 'project', dirs_exist_ok=True)